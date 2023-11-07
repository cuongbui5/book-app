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
using Book_App.Models;
using Book_App.Util;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuAnimatorNS;

namespace Book_App.Views
{
    partial class BookItem : UserControl
    {
        private Book book;
        private BunifuPages control;
        private HomeControl home;
        public BookItem(Book book, BunifuPages control,HomeControl homeControl)
        {
            
            InitializeComponent();
          
            this.book = book;
            this.control = control;
            this.home = homeControl;
           
        }

        private void BookItem_Load(object sender, EventArgs e)
        {
            lblPriceItem.Text = book.Price.ToString();
            lblNameItem.Text=book.Title.ToString();
            ratingItem.Value = book.Rating;
            byte[] imageData = book.ImageCover; 
            ptImageItem.Image= ImageHelper.byteToImage(imageData);

        }

       

       

        private void ptImageItem_Click(object sender, EventArgs e)
        {
            control.SetPage("detailProductPage");
            home.LoadProductDetail(book);
        }
    }
}
