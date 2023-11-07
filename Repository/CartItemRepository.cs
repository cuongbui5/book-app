using Book_App.Database;
using Book_App.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Book_App.Repository
{
    class CartItemRepository
    {
        private static CartItemRepository instance;

        public static CartItemRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CartItemRepository();
                }
                return instance;
            }
        }

        public bool CreateCartItem(CartItem cartItem)
        {
            string query = "INSERT INTO cart_item (book_id, cart_id, quantity, created_at) " +
                "VALUES (@BookId, @CartId, @Quantity, @CreateAt)";

            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand cmd = new SqlCommand(query,DBUtil.Instance.Connection);
                cmd.Parameters.AddWithValue("@BookId", cartItem.BookId);
                cmd.Parameters.AddWithValue("@CartId", cartItem.CartId);
                cmd.Parameters.AddWithValue("@Quantity", cartItem.Quantity);
                cmd.Parameters.AddWithValue("@CreateAt", DateTime.Now);
                int row = cmd.ExecuteNonQuery();
                return row > 0; 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                DBUtil.Instance.Close();
            }
        }
        public bool DeleteCartItemById(int id)
        {
            string query = "DELETE FROM cart_item WHERE Id = @Id";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, DBUtil.Instance.Connection);
                cmd.Parameters.AddWithValue("@Id", id);

                return cmd.ExecuteNonQuery()>0;
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);    
        
            }
            finally
            { 
                DBUtil.Instance.Close();
            }

           
        }


        public bool DeleteCartItemByCartId(int cartId) {
            string query = "delete from cart_item where cart_id=@cartId";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand command=new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@cartId", cartId);
                return command.ExecuteNonQuery()>0;

            }catch (Exception ex) {
                throw new Exception(ex.Message);    
            
            
            
            }
            finally { DBUtil.Instance.Close(); }

        
        }

        public float GetTotalPriceByCartId(int cartId)
        {
            string query = "select sum(a.quantity*b.price) from cart_item a join book b on a.book_id=b.id where a.cart_id=@cartId group by a.cart_id";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, DBUtil.Instance.Connection);
                cmd.Parameters.AddWithValue("@cartId", cartId);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToSingle(result);
                }
                else
                {                 
                    return 0.0f; 
                }
               

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                DBUtil.Instance.Close();
            }
        }

        


        public List<CartItem> GetCartItemsByCartId(int cartId) {
            string query = "select * from cart_item a join book b on a.book_id=b.id where a.cart_id=@cartId";
            List<CartItem>  cartItems = new List<CartItem>();
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand command=new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@cartId", cartId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) { 
                    Book book = new Book();
                    book.Id = int.Parse(reader["book_id"].ToString());
                    book.Title = reader["Title"].ToString();
                    book.Price = float.Parse(reader["price"].ToString());
                    book.ImageCover = (byte[])reader["image_cover"];
                    CartItem item = new CartItem(); 
                    item.Book= book;
                    item.BookId = book.Id;
                    item.Id = int.Parse( reader["id"].ToString());
                    item.Quantity = int.Parse(reader["quantity"].ToString()) ;
                    item.CreateAt =DateTime.Parse( reader["created_at"].ToString());
                    cartItems.Add(item);
                   
                
                }
                


            }catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
            finally { DBUtil.Instance.Close(); }

            return cartItems;

        }

        public bool UpdateCartItemById(string quantity,int cattItemId)
        {
            string query = "update cart_item set quantity=@quantity where id=@id";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand command=new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@id", cattItemId);
                return command.ExecuteNonQuery()>0;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            
            }
            finally { DBUtil.Instance.Close(); }
        }
    }
}
