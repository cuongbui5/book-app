using Book_App.Database;
using Book_App.Models;
using System;
using System.Data.SqlClient;


namespace Book_App.Repository
{
    class CategoryRepository
    {
        private static CategoryRepository instance;

        public static CategoryRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryRepository();
                }
                return instance;
            }
        }

      
        public bool CreateCategory(Category category)
        {
            try
            {
                DBUtil.Instance.OpenConnection();
                string query = "insert into category (name) values (@name)";
                SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@name", category.Name);
                return command.ExecuteNonQuery() > 0;

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

        
        public bool UpdateCategoryById(string name,string id)
        {
            try
            {
                DBUtil.Instance.OpenConnection();
                string query = "update category set name = @name where id = @id";
                SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                return command.ExecuteNonQuery() > 0;
               
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

      
        public bool DeleteCategoryById(string categoryId)
        {
            try
            {
                DBUtil.Instance.OpenConnection();
                string query = "delete from category where id = @id";
                SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@id", categoryId);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
              
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
