using Book_App.Models;
using Book_App.Services;
using Bunifu.UI.WinForms;
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
    partial class BookControl : UserControl
    {
        public BunifuPages ControlPage { get; set; }
        private OpenFileDialog openFileDialog;
        private int bookId=0;
        private byte[] imageCoverCurrent;
       
        public BookControl()
        {
            InitializeComponent();
            ControlPage = bunifuPages1;
            LoadBooks(); 
        }

        public void LoadBooks()
        {
            BookGridView.DataSource = BookService.Instance.LoadDataSetBooks().Tables[0];
        }

      

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("detailPage");
            LoadCategories();
            Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadBooks();
            bunifuPages1.SetPage("bookList");
        }

        public void LoadCategories()
        {
            List<Category> categories = CategoryService.Instance.getListCategory();
            CategoryDropDown.Items.Clear();    
            foreach (Category category in categories)
            {
                CategoryDropDown.Items.Add(category.Id + "-" + category.Name);

            }
        }

        public void LoadCategoryUpdateBook(int id)
        {
            List<Category> categories = CategoryService.Instance.getListCategory();
            CategoryDropDown.Items.Clear();
            foreach (Category category in categories)
            {
                CategoryDropDown.Items.Add(category.Id + "-" + category.Name);
                if(category.Id == id)
                {
                    CategoryDropDown.SelectedItem= category.Id + "-" + category.Name;
                }

            }
        }

        private void bunifuPages1_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        public int getCategoryByString(string input)
        {
            string[] parts = input.Split('-');       
            string id = parts[0];
            return int.Parse(id);
               
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                string title = txtTitle.Text;
                string author = txtAuthor.Text;
                string description = txtDescription.Text;
                float price =float.Parse(txtPrice.Text);
                int rating = ratingBook.Value;
                if (title == "" || author == "" || description == "" || rating == 0)
                {
                    MessageBox.Show("Fields cannot be left blank and ratings range from 1 to 5!");
                    return;
                }
                
                if(CategoryDropDown.SelectedItem == null)
                {
                    MessageBox.Show("Please choose category!");
                    return;
                }
                int categoryId= getCategoryByString(CategoryDropDown.SelectedItem.ToString());
               
                Book book = new Book();
                book.Title = title;
                book.Author = author;
                book.Description = description;
                book.Price = price;
                book.Rating = rating;
                book.CategoryId = categoryId;
                if (openFileDialog != null&&openFileDialog.FileName!="")
                {
                    book.ImageCover = File.ReadAllBytes(openFileDialog.FileName);
                }
               
                book.CreatedAt = DateTime.Now;
                if(bookId == 0)
                {
                    //create
                    bool result = BookService.Instance.CreateBook(book);
                    if (result)
                    {
                        MessageBox.Show("create book successfully!");

                    }
                    else
                    {
                        MessageBox.Show("create book fail!");
                    }
                }
                else
                {
                    

                    if (book.ImageCover == null&& imageCoverCurrent!=null) {
                        
                        book.ImageCover = imageCoverCurrent;
                    }
                    bool result = BookService.Instance.UpdateBook(book,bookId);
                    if (result)
                    {
                        MessageBox.Show("update book successfully!");                                            
                       
                    }
                    else
                    {
                        MessageBox.Show("update book fail!");
                    }

                }
               



            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
           
            
            
           
            
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh"; 
            openFileDialog.Filter = "Tệp hình ảnh (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png; ";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;

                try
                {
                   
                    ptImageCover.Image = Image.FromFile(selectedImagePath);

                  
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                }


            }
        }

       

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
                             
            bunifuPages1.SetPage("detailPage");
            DataGridViewRow dataGridViewRow = BookGridView.CurrentRow;
            LoadCategoryUpdateBook(int.Parse(dataGridViewRow.Cells["category_id"].Value.ToString()));
            bookId =int.Parse( dataGridViewRow.Cells["id"].Value.ToString());
            txtBookId.Text = bookId.ToString();
            txtTitle.Text = dataGridViewRow.Cells["title"].Value.ToString();
            txtPrice.Text = dataGridViewRow.Cells["price"].Value.ToString();
            txtAuthor.Text = dataGridViewRow.Cells["author"].Value.ToString();
            txtDescription.Text = dataGridViewRow.Cells["description"].Value.ToString();
            ratingBook.Value =int.Parse( dataGridViewRow.Cells["rating"].Value.ToString());           
            imageCoverCurrent = (byte[])dataGridViewRow.Cells["image_cover"].Value;
            if (imageCoverCurrent != null && imageCoverCurrent.Length > 0)
            {              
                using (MemoryStream ms = new MemoryStream(imageCoverCurrent))
                {
                    Image image = Image.FromStream(ms);         
                    ptImageCover.Image = image;
                    
                }
            }

        }
        private void Refresh()
        {
            txtDescription.Text =string.Empty;
            txtTitle.Text =string.Empty;
            txtPrice.Text =string.Empty;
            txtAuthor.Text =string.Empty;
            txtBookId.Text = string.Empty;
            ptImageCover.Image =null;
            openFileDialog = null;      
            CategoryDropDown.SelectedIndex = 0;
            imageCoverCurrent = null;
            ratingBook.Value = 5;
            bookId = 0;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = BookGridView.CurrentRow;
            string id = row.Cells["id"].Value.ToString();
            try
            {
                bool result = BookService.Instance.DeleteBook(id);
                if (result)
                {
                    MessageBox.Show("delete successfully!");
                    LoadBooks();
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
