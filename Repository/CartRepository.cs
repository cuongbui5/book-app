using Book_App.Database;
using Book_App.Models;
using System;
using System.Data.SqlClient;
namespace Book_App.Repository
{
    class CartRepository
    {
        private static CartRepository instance;

        public static CartRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CartRepository();
                }
                return instance;
            }
        }

      


        public bool CreateCart(string userId)
        {
            string query = "insert into cart(user_id) values (@userId); SELECT SCOPE_IDENTITY();";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@userId", userId);
                return command.ExecuteNonQuery()>0;
              
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
        public Cart GetCartByUserId(int userId)
        {
            string query = "SELECT * FROM cart WHERE user_id = @UserId";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand sql = new SqlCommand(query, DBUtil.Instance.Connection);
                sql.Parameters.AddWithValue("@UserId", userId);

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Cart cart = new Cart
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        UserId = int.Parse(reader["user_id"].ToString())
                       
                    };

                    return cart;
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
            return null;
        }

       

    }
}
