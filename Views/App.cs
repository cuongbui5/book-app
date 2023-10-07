using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_App.Models;
using Book_App.Services;
using Book_App.Views;
using Bunifu.UI.WinForms;

namespace Book_App.Views
{
    partial class App : UserControl
    {
        private User user;
        private BunifuPages mainPage;  
        private BookControl bookControl;
        public HomeControl homeControl { get; set; }
        private Cart cartCurrent;
        private bool authorization=false;
        private bool IsHomePage=true;

        public void setCartCurrent(Cart cart)
        {
            this.cartCurrent = cart;
            homeControl.setCartCurrent(cart);

        }

        
        

        public void setUser(User user)
        {
            this.user = user;
            if(user.Role=="ADMIN" )
            {
                authorization = true;
            }
            else
            {
                authorization = false;
            }
            lblUsername.Text = user.UserName;
            lblRole.Text = user.Role;
           
        }

       
        public App(BunifuPages mainPage)
        {
            InitializeComponent();    
            this.mainPage = mainPage;
            this.bookControl = new BookControl();
            this.homeControl = new HomeControl();
            bookPage.Controls.Add(this.bookControl);
            this.bookControl.Dock= DockStyle.Fill;  
            homePage.Controls.Add(this.homeControl);
            this.homeControl.Dock = DockStyle.Fill;



        }

      

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageTitle = "homePage";
            IsHomePage = true;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            IsHomePage = false;
            if (!authorization)
            {
                MessageBox.Show("user does not have access rights!");
                return;
            }
            bunifuPages1.PageTitle="categoryPage";
            LoadCategoryData();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            IsHomePage = false;
            if (!authorization)
            {
                MessageBox.Show("user does not have access rights!");
                return;
            }
            bunifuPages1.PageTitle = "bookPage";
            
           
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            IsHomePage = false;
            if (!authorization)
            {
                MessageBox.Show("user does not have access rights!");
                return;
            }
            bunifuPages1.PageTitle = "userPage";
            LoadUserData();
        }

     

       

      
        private void bunifuButton5_Click_1(object sender, EventArgs e)
        {          
            mainPage.SetPage("loginPage");
            bunifuPages1.SetPage("homePage");
            bookControl.ControlPage.SetPage("bookList");
            homeControl.ControlPage.SetPage("productPage");



        }

        public void LoadCartItem()
        {

            try
            {
                cartItemContainer.Controls.Clear();
                Cart cart = CartService.Instance.GetCartByUserId(user.Id);
                List<CartItem> cartItems=CartItemService.Instance.GetCartItemsByCartId(cart.Id);
                if(cartItems.Count==0)
                {
                    MessageBox.Show("empty cart!");
                    return;
                }
                cartItems.ForEach(cartItem =>
                {
                    CartItemControl cartItemControl = new CartItemControl(cartItem,this);
                    cartItemContainer.Controls.Add(cartItemControl);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadTotalPrice()
        {
            try
            {
                float totalPrice = CartItemService.Instance.GetTotalPriceByCartId(cartCurrent.Id);
                lblTotal.Text = totalPrice.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            IsHomePage=false;
            if (user!=null)
            {
                bunifuPages1.SetPage("cartPage");
                LoadCartItem();
                LoadTotalPrice();
            }
           
            //MessageBox.Show("Admin does not have access rights!");

        }

    

    
        private void bunifuButton7_Click(object sender, EventArgs e)
        {
           
            DataGridViewRow selectedRow = bunifuDataGridView1.CurrentRow;
            if (selectedRow != null)
            {
                try
                {
                    string id =selectedRow.Cells["id"].Value.ToString();
                    string role = selectedRow.Cells["role"].Value.ToString();
                    if (user.Id.ToString() == id || role == "ADMIN")
                    {
                        MessageBox.Show("Unauthorized!");
                        return;
                    }                
                    bool result = UserService.Instance.LockUserById(id);
                    if (result)
                    {
                        MessageBox.Show("Lock user successfully!");
                        LoadUserData();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                }
                catch(Exception ex) { 
                    MessageBox.Show(ex.Message);
                }
              
               

            }
        }

        public void LoadUserData()
        {
            bunifuDataGridView1.DataSource = UserService.Instance.GetAllUsers().Tables[0];
        }


        public void LoadCategoryData()
        {
            categoryGridView.DataSource = CategoryService.Instance.GetAllCategories().Tables[0];
        }
        private void bunifuDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {            
                string password = e.Value.ToString();
                e.Value = new string('*', password.Length);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtCategoryId.Text.Trim();
                string newName = txtCategoryName.Text.Trim();
                if (id == "" && newName != "")
                {
                    bool result = CategoryService.Instance.CreateCategory(newName);
                    if (result)
                    {
                        MessageBox.Show("Add category successfully!");
                        LoadCategoryData();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                }
                else
                {
                    MessageBox.Show("Input not valid!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }









        }

    

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCategoryId.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtCategoryId.Text.Trim();
                string newName = txtCategoryName.Text.Trim();
                if (id !="" && newName!="")
                {
                    bool result = CategoryService.Instance.updateCategoryById(newName,id);
                    if (result)
                    {
                        MessageBox.Show("Update category successfylly!");
                        LoadCategoryData();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                }
                else
                {
                    MessageBox.Show("Input not valid!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeteleCategory_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow=categoryGridView.CurrentRow;
            if (selectedRow != null)
            {
                string id = selectedRow.Cells["id"].Value.ToString();
                try
                {
                    bool result = CategoryService.Instance.deleteCategoryById(id);
                    if (result)
                    {
                        MessageBox.Show("Delete category successfully!");
                        LoadCategoryData();

                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                   
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
           
        }

       
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (!IsHomePage)
            {
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                string title = txtSearch.Text.Trim();
                if (title != "")
                {
                    this.homeControl.searchBook(title);
                }
                else
                {
                    MessageBox.Show("Please enter title!");
                }

                
            }

           
        }

     

        private void bunifuButton12_Click(object sender, EventArgs e)
        {

           
            if (lblTotal.Text.Trim() == "0")
            {
                return;
            }
            Order order = new Order();
            order.Total=float.Parse(lblTotal.Text);
            order.CreatedAt= DateTime.Now;
            order.UserId = cartCurrent.UserId;
            try
            {
                bool result=OrderService.Instance.CreateOrder(order);
                bool deleteAllCartItem = CartItemService.Instance.DeleteCartItemByCartId(cartCurrent.Id);
                if(result&&deleteAllCartItem)
                {
                    MessageBox.Show("Create order successfully!");
                    LoadCartItem();
                    LoadTotalPrice();
                    
                    
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
        public void LoadOrder()
        {
            try
            {
                orderGridView.DataSource = OrderService.Instance.GetOrdersByUserId(user.Id).Tables[0];
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("orderPage");
            LoadOrder();    
        }

      

        private void categoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = categoryGridView.CurrentRow;
            if (selectedRow != null)
            {
                txtCategoryId.Text = selectedRow.Cells["id"].Value.ToString();
                txtCategoryName.Text = selectedRow.Cells["name"].Value.ToString();
            }
        }
    }
}
