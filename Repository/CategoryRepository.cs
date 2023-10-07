using Book_App.Database;
using Book_App.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

       

        public Category FindCategoryById(string id) { 
            Category category = null;
            string query = "select * from category where id=@id";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    category = new Category()
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        Name = reader["name"].ToString()
                    };
                   
                    return category;
                }
                else
                {
                    throw new Exception("Not found Category with id"+id);
                }

            }catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
            finally
            {
                DBUtil.Instance.Close();
            }


        }


        public List<Category> GetListCategories()
        {
            List<Category> categories = new List<Category>();
            string query = "SELECT * FROM Category";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Category category = new Category
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        Name = reader["name"].ToString()
                    };
                    categories.Add(category);
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

            return categories;
        }


        public DataSet GetAllCategories()
        {
            DataSet result = new DataSet();
            string query = "select * from category";
            try
            {
                DBUtil.Instance.OpenConnection();

                SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);

                return result;
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
