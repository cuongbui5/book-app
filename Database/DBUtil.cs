using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_App.Database
{
     class DBUtil
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=MSI\\BUICUONG;Initial Catalog=book_app;Integrated Security=True";

        public SqlConnection Connection { get => connection; }

        private static DBUtil instance;

        public static DBUtil Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBUtil();
                }
                return instance;
            }
        }
        public void OpenConnection()
        {
            try
            {
               
                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);
                }
             
                connection.Open();
                
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        public void Close()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable GetList(string table)
        {
            DataTable dt = new DataTable();
            string query = "select * from " + table;
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally {
                Close();
            }
        }
    }
}
