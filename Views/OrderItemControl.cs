using Book_App.Models;
using Book_App.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Book_App.Views
{
    partial class OrderItemControl : UserControl
    {
        private OrderItem orderItem;
        public OrderItemControl(OrderItem orderItem)
        {
            InitializeComponent();
            this.orderItem = orderItem;
        }

        private void OrderItemControl_Load(object sender, EventArgs e)
        {
            lblTitle.Text = orderItem.BookTitle;
            lblPrice.Text = orderItem.BookPrice.ToString();
            lblQuantity.Text = orderItem.Quantity.ToString();
            lblTotal.Text = orderItem.Price.ToString();
            byte[] imageCover = orderItem.BookImage;
            ptImageCover.Image = ImageHelper.byteToImage(imageCover);
        }
    }
}
