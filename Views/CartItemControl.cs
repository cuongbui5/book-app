using Book_App.Models;
using Book_App.Services;
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
    partial class CartItemControl : UserControl
    {
        private CartItem cartItem;
        private App app;
        public CartItemControl(CartItem cartItem,App app)
        {
            InitializeComponent();
            this.cartItem = cartItem;
            this.app = app;
        }

        private void CartItemControl_Load(object sender, EventArgs e)
        {
            lblTitle.Text=cartItem.Book.Title;
            lblPrice.Text=cartItem.Book.Price.ToString();
            txtQuantity.Text=cartItem.Quantity.ToString();
            lblCreatedAt.Text=cartItem.CreateAt.ToString();
            byte[] imageCover=cartItem.Book.ImageCover;
            if(imageCover != null&& imageCover.Length > 0)
            {
                using(MemoryStream ms=new MemoryStream(imageCover))
                {
                    ptImageCover.Image=Image.FromStream(ms);
                }
            }
            else
            {
                ptImageCover = null;
            }
           
        }

        private void btnDeleteCartItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(CartItemService.Instance.DeleteCartItem(cartItem.Id))
                {
                    MessageBox.Show("Delete successfully!");
                    app.LoadCartItem();
                    app.LoadTotalPrice();
                }
                else
                {
                    MessageBox.Show("Somethings wrong!");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string quantity = txtQuantity.Text.Trim();
                if (quantity != "")
                {
                    try
                    {
                        bool result = CartItemService.Instance.UpdateQuantityByCartId(quantity, cartItem.Id);
                        if (result)
                        {
                            app.LoadCartItem();
                            app.LoadTotalPrice();
                        }
                        else
                        {
                            MessageBox.Show("Somethings wrong!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
