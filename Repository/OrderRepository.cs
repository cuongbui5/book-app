using Book_App.Database;
using Book_App.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Book_App.Repository
{
    class OrderRepository
    {
        private static OrderRepository instance;

        public static OrderRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderRepository();
                }
                return instance;
            }
        }

        public DataSet GetOrdersByUserId(int userId)
        {
            string query = "select * from orders where user_id=@userId";
            DataSet data = new DataSet();
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, DBUtil.Instance.Connection);
                cmd.Parameters.AddWithValue("@userId", userId);
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                return data;

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

        public string CreateOrder(Order order)
        {

            string query = "insert into orders(total,user_id,created_at) values(@total,@user_id,@createdAt); SELECT SCOPE_IDENTITY()";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand cmd = new SqlCommand(query,DBUtil.Instance.Connection);
                cmd.Parameters.AddWithValue("@total", order.Total);
                cmd.Parameters.AddWithValue("@user_id", order.UserId);
                cmd.Parameters.AddWithValue("@createdAt", order.CreatedAt);

                return cmd.ExecuteScalar().ToString();


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
    }
}
