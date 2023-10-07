using Book_App.Repository;
using Book_App.Services;
using Book_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_App.Views;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;

namespace Book_App
{
    partial class BookApp : Form
    {
        
        private User userDetail;
   
        private App app;
       
        public BookApp()
        {
            InitializeComponent();
            MaximizeBox = false;
            app = new App(bunifuPages1);                   
            mainPage.Controls.Add(app);
            app.Dock = DockStyle.Fill;
        }

      

        private void lblCA_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("registerPage");
            
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            RefreshRegister();
            bunifuPages1.SetPage("loginPage");
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            txtPasswordRegister.PasswordChar = '\0';
            txtPasswordRegister.UseSystemPasswordChar = false;
            bunifuImageButton2.Visible = false;
            bunifuImageButton1.Visible = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            txtPasswordRegister.UseSystemPasswordChar = true;
            bunifuImageButton1.Visible = false;
            bunifuImageButton2.Visible = true;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            txtPasswordConfirm.UseSystemPasswordChar = true;
            bunifuImageButton3.Visible = false;
            bunifuImageButton4.Visible = true;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            txtPasswordConfirm.PasswordChar = '\0';
            txtPasswordConfirm.UseSystemPasswordChar = false;
            bunifuImageButton4.Visible = false;
            bunifuImageButton3.Visible = true;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            txtPasswordLogin.PasswordChar = '\0';
            txtPasswordLogin.UseSystemPasswordChar = false;
            bunifuImageButton5.Visible = false;
            bunifuImageButton6.Visible = true;
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            txtPasswordLogin.UseSystemPasswordChar = true;
            bunifuImageButton6.Visible = false;
            bunifuImageButton5.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username=txtUsernameRegister.Text.Trim();
            string password=txtPasswordRegister.Text.Trim();
            string passwordConfirm=txtPasswordConfirm.Text.Trim();
            if(username == "" || password == "" || passwordConfirm == "")
            {
                lblMessageRegister.Text = "Fields cannot be left blank!";
                return;
            }
            if (password!=passwordConfirm)
            {
                lblMessageRegister.Text = "Password Confirm do not match!";
                return;
            }
            try
            {
                bool result = AuthService.Instance.Register(username, password);
               
                if (result)
                {
                    MessageBox.Show("Register successfuly!");                   
                    RefreshRegister();

                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            catch (Exception ex)
            {
                lblMessageRegister.Text = ex.Message;
            }
        }
        private void RefreshRegister()
        {
            txtUsernameRegister.Text = string.Empty;
            txtPasswordRegister.Text = string.Empty;
            txtPasswordConfirm.Text = string.Empty;
            lblMessageRegister.Text = string.Empty;

        }
        private void RefreshLogin()
        {
            lblMessageLogin.Text = string.Empty;
            if (cbRemember.Checked)
            {
                return;
            }
            txtUsernameLogin.Text = string.Empty;
            txtPasswordLogin.Text = string.Empty;     
           

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text.Trim();
            string password = txtPasswordLogin.Text.Trim();
            if (username == "" || password == "")
            {
                lblMessageLogin.Text = "Fields cannot be left blank!";
                return;
            }
            try
            {
                userDetail = AuthService.Instance.Login(username, password);
                if (userDetail != null)
                {
                    
                    RefreshLogin();
                    app.setUser(userDetail);
                    Cart cart = CartService.Instance.GetCartByUserId(userDetail.Id);
                    app.setCartCurrent(cart);
                    app.homeControl.Refresh();
                    bunifuPages1.SetPage("mainPage");




                }

            }
            catch (Exception ex)
            {
                lblMessageLogin.Text = ex.Message;

            }
        }

        

    

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            userDetail = null;                    
            bunifuPages1.SetPage("loginPage");
        }

        private void BookApp_Load(object sender, EventArgs e)
        {
          
        }

        private void bunifuPages1_Selected(object sender, TabControlEventArgs e)
        {
            
        }
    }
}
