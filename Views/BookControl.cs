using Book_App.Commons;
using Book_App.Database;
using Book_App.Models;
using Book_App.Services;
using Book_App.Util;
using Bunifu.UI.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.IO;
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
            BookGridView.DataSource = DBUtil.Instance.GetList("ListBook");
        }

      

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("detailPage");
            lblAction.Text = "Create New Book";
            Refresh();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = BookGridView.CurrentRow;
            LoadCategoryUpdateBook(dataGridViewRow.Cells["Category"].Value.ToString());
            bookId = int.Parse(dataGridViewRow.Cells["Id"].Value.ToString());
            txtBookId.Text = bookId.ToString();
            txtTitle.Text = dataGridViewRow.Cells["Title"].Value.ToString();
            txtPrice.Text = dataGridViewRow.Cells["Price"].Value.ToString();
            txtAuthor.Text = dataGridViewRow.Cells["Author"].Value.ToString();
            txtDescription.Text = dataGridViewRow.Cells["Description"].Value.ToString();
            ratingBook.Value = int.Parse(dataGridViewRow.Cells["Rating"].Value.ToString());
            imageCoverCurrent = (byte[])dataGridViewRow.Cells["Image"].Value;
            ptImageCover.Image = ImageHelper.byteToImage(imageCoverCurrent);
            bunifuPages1.SetPage("detailPage");
            lblAction.Text = "Update Book(#" + bookId + ")";


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadBooks();
            bunifuPages1.SetPage("bookList");
            lblAction.Text = "CRUD BOOK";
        }

       

        public void LoadCategoryUpdateBook(string category)
        {
           
            
           
            LoadData.LoadDropDown("category", CategoryDropDown);
            foreach (var item in CategoryDropDown.Items)
            {
                if (item is DataRowView)
                {
                    DataRowView rowView = item as DataRowView;
                    string name = rowView["name"].ToString();
                    if (name ==category)
                    {
                        CategoryDropDown.SelectedValue = rowView["id"];
                        break; 
                    }
                }
            }
           

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
                int categoryId = (int)CategoryDropDown.SelectedValue;
               
                if (title == "" || author == "" || description == "" || rating == 0||categoryId==0)
                {
                    MessageBox.Show("Fields cannot be left blank and ratings range from 1 to 5!");
                    return;
                }
                
                if(CategoryDropDown.SelectedItem == null)
                {
                    MessageBox.Show("Please choose category!");
                    return;
                }
               
               
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

       

       
        private void Refresh()
        {
            txtDescription.Text =string.Empty;
            txtTitle.Text =string.Empty;
            txtPrice.Text =string.Empty;
            txtAuthor.Text =string.Empty;
            txtBookId.Text = string.Empty;
            ptImageCover.Image =null;
            openFileDialog = null;      
            CategoryDropDown.SelectedIndex = -1;
            imageCoverCurrent = null;
            ratingBook.Value = 5;
            bookId = 0;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = BookGridView.CurrentRow;
            string id = row.Cells["id"].Value.ToString();
            if (id != "")
            {
                DialogResult dialog = MessageBox.Show("Do you want delete book with id=" + id, "Delete book", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        bool result = BookService.Instance.DeleteBook(id);
                        if (result)
                        {
                            MessageBox.Show("delete successfully!");
                            LoadBooks();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    return;
                }
            }
           
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void CategoryDropDown_Click(object sender, EventArgs e)
        {
            LoadData.LoadDropDown("category", CategoryDropDown);
        }

       
    }
}
