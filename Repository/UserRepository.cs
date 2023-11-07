using System;
using System.Data.SqlClient;
using Book_App.Database;
using Book_App.Models;


namespace Book_App.Repository
{
    class UserRepository
    {

        private static UserRepository instance;

        public static UserRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserRepository();
                }
                return instance;
            }
        }



       


        public string CreateUser(User user)
        {
            try
            {             
                DBUtil.Instance.OpenConnection();
                string query = "INSERT INTO Users (username, password, role) VALUES (@username, @password, @role); SELECT SCOPE_IDENTITY()";
                SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@username", user.UserName);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@role", user.Role);

                return command.ExecuteScalar().ToString();

            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            finally
            {
                DBUtil.Instance.Close();
            }
            
        }

      

        public User FindUserByUsername(string username)
        {
            string query = "select * from users where username = @username";

            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@Username", username);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    User user = new User()
                    {

                        Id = int.Parse(reader["id"].ToString()),
                        UserName = reader["username"].ToString(),
                        Password = reader["password"].ToString(),
                        Role = reader["role"].ToString(),
                        IsLocked = reader.GetBoolean(reader.GetOrdinal("IsLocked"))
                    };


                    return user;
                }
                else
                {
                    throw new Exception("Not found user with username:"+username);
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

        public bool LockUser(string userId)
        {
            string query = "update users set IsLocked=1 where id=@userId";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@userId", userId);
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

        public bool UnLockUser(string userId)
        {
            string query = "update users set IsLocked=0 where id=@userId";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@userId", userId);
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
    }
}
