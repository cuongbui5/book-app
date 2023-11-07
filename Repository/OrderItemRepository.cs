using Book_App.Database;
using Book_App.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Book_App.Repository
{
    class OrderItemRepository
    {
        private static OrderItemRepository instance;

        public static OrderItemRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderItemRepository();
                }
                return instance;
            }
        }

        public bool CreateOrderItem(OrderItem orderItem)
        {
            string query = "INSERT INTO order_item (order_id, book_id, quantity, price) " +
                "VALUES (@OrderId, @BookId, @Quantity, @Money)";

            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, DBUtil.Instance.Connection);
                cmd.Parameters.AddWithValue("@OrderId", orderItem.OrderId);
                cmd.Parameters.AddWithValue("@BookId", orderItem.BookId);
                cmd.Parameters.AddWithValue("@Quantity", orderItem.Quantity);
                cmd.Parameters.AddWithValue("@Money", orderItem.Price);
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

        public List<OrderItem> GetOrderItemsByOrderId(string orderId)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            string query = "select a.id,a.quantity,a.price,b.title,b.price as book_price ,b.image_cover from order_item a join book b on a.book_id=b.id where a.order_id="+orderId;
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, DBUtil.Instance.Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    OrderItem orderItem = new OrderItem
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Quantity = Convert.ToInt32(reader["quantity"]),
                        Price = float.Parse(reader["price"].ToString()),
                        BookTitle = reader["Title"].ToString(),
                        BookPrice = float.Parse(reader["book_price"].ToString()),
                        BookImage = (byte[])reader["image_cover"]
                    };





                    orderItems.Add(orderItem);

                }

                return orderItems;
             
               
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
