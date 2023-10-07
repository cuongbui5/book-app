using Book_App.Models;
using Book_App.Services;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_App.Views
{
     partial class HomeControl : UserControl
    {
        private Cart cartCurrent;
        
        public BunifuPages ControlPage { get; }
        public HomeControl()
        {
            InitializeComponent();
            ControlPage = bunifuPages1;


        }

        public void setCartCurrent(Cart cart)
        {
            this.cartCurrent = cart;
        }

        public void LoadCategory()
        {
            categoryFilterDropDown.Items.Clear();
            try
            {
                List<Category> categories = CategoryService.Instance.getListCategory();
                categories.ForEach(c =>
                {
                    categoryFilterDropDown.Items.Add(c.Id+"-"+c.Name);
                });

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
           
           
            
        }

       

        private void HomeControl_Load(object sender, EventArgs e)
        {
            LoadCategory();

        }

        public void searchBook(string title)
        {
           
            try
            {
                List<Book> books = BookService.Instance.FindBooksByTitle(title);
                ShowListBook(books);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   

        public void ShowListBook(List<Book> books)
        {
           
            itemContainer.Controls.Clear();
            
            books.ForEach(book =>
            {
                BookItem item = new BookItem(book, bunifuPages1, this);
                itemContainer.Controls.Add(item);

            });
           

            
        }

      

        public List<Book> LoadBooks()
        {
            
            try
            {
                List<Book> books = BookService.Instance.GetListBook();
                return books;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void LoadProductDetail(Book book)
        {
            lblBookId.Text = book.Id.ToString();
            lblTitle.Text = book.Title; 
            lblAuthor.Text=book.Author;
            lblCategoryName.Text = book.CategoryName;
            lblPrice.Text=book.Price.ToString();    
            ratingProduct.Value = book.Rating;
            rtbDescription.Text = book.Description;
            byte[] imageData = book.ImageCover;
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    ptImageCover.Image = Image.FromStream(ms);
                }
            }
            else
            {

                ptImageCover.Image = null;
            }
        }

     

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("productPage");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
           
            Refresh();

        }

        public void Refresh()
        {
            List<Book> books = LoadBooks();
            ShowListBook(books);      
            categoryFilterDropDown.Text = "";
            priceFilterDropDown.Text = "";

        }

        private void btnCartItem_Click(object sender, EventArgs e)
        {
            if (cartCurrent == null)
            {
                MessageBox.Show("Something wrong!");
                return;
            }

            try
            {

                //Check book 
                //find 
                int bookId = int.Parse(lblBookId.Text);
                

                List<CartItem> items = CartItemService.Instance.GetCartItemsByCartId(cartCurrent.Id);
                foreach(CartItem item in items)
                {
                    if(item.BookId == bookId)
                    {
                        MessageBox.Show("Products already in the cart!");
                        return;
                    }
                }

                CartItem cartItem=new CartItem();
                cartItem.BookId=bookId;
                cartItem.CreateAt = DateTime.Now;
                cartItem.Quantity = 1;
                cartItem.CartId = cartCurrent.Id;
                bool result= CartItemService.Instance.CreateCartItem(cartItem);
                if(result)
                {
                    MessageBox.Show("Add cart successfully!");
                }
                else{
                    MessageBox.Show("Somethings wrong!");
                }
                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int getCategoryByString(string input)
        {
            string[] parts = input.Split('-');
            string id = parts[0];
            return int.Parse(id);


        }

       

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                List<Book> books=new List<Book>();
                
                string dataPrice;
                string dataCategory;


                if (priceFilterDropDown.SelectedItem == null && categoryFilterDropDown.SelectedItem == null)
                {
                    MessageBox.Show("no action!");
                    return;
                }
                else if (priceFilterDropDown.SelectedItem == null && categoryFilterDropDown.SelectedItem != null)
                {
                    //filter by category
                    dataCategory = categoryFilterDropDown.SelectedItem.ToString();
                    int categoryId = getCategoryByString(dataCategory);
                    books =BookService.Instance.FilterBookByCategoryId(categoryId) ;    

                }
                else if (priceFilterDropDown.SelectedItem != null && categoryFilterDropDown.SelectedItem == null)
                {
                    //filter by price
                    dataPrice = priceFilterDropDown.SelectedItem.ToString();
                    string[] parts = dataPrice.Split('-');
                    float min = float.Parse(parts[0]);
                    float max = float.Parse(parts[1]);
                    books = BookService.Instance.FilterBookByPrice(min,max);
                }
                else
                {
                    //filter by category and price
                    dataPrice = priceFilterDropDown.SelectedItem.ToString();
                    dataCategory = categoryFilterDropDown.SelectedItem.ToString();
                    int categoryId = getCategoryByString(dataCategory);
                    string[] parts = dataPrice.Split('-');
                    float min = float.Parse(parts[0]);
                    float max = float.Parse(parts[1]);
                    books = BookService.Instance.FilterBookByCategoryIdAndPrice(categoryId,min, max);
                }
                ShowListBook(books);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

       

      
    }
}
