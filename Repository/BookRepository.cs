using Book_App.Database;
using Book_App.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_App.Repository
{
    class BookRepository
    {
        private static BookRepository instance;

        public static BookRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookRepository();
                }
                return instance;
            }
        }

        public int CountBooksByTitle(string title)
        {
            string query = "SELECT COUNT(*) FROM book WHERE title = @title";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection);
                command.Parameters.AddWithValue("@title", title);
                int count = (int)command.ExecuteScalar();
                return count;
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



        public DataSet GetAllBooks() { 
            DataSet result = new DataSet();
            string query = "select * from book";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand command=new SqlCommand(query,DBUtil.Instance.Connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                return result;

            }catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            finally
            {
                DBUtil.Instance.Close();
            }

        }

        public List<Book> FindBooksByTitle(String title)
        {
            List<Book> foundBooks = new List<Book>();
            string query = "SELECT * FROM book a join category b on a.category_id=b.id WHERE a.title LIKE @SearchTerm";

            try
            {
                DBUtil.Instance.OpenConnection();
                using (SqlCommand command = new SqlCommand(query, DBUtil.Instance.Connection))
                {
                    command.Parameters.AddWithValue("@SearchTerm", "%" + title + "%"); 
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Book book = new Book
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Title = reader["title"].ToString(),
                                Price = float.Parse(reader["price"].ToString()),
                                ImageCover = (byte[])reader["image_cover"],
                                Rating = int.Parse(reader["rating"].ToString()),
                                Description = reader["description"].ToString(),
                                Author = reader["Author"].ToString(),
                                CategoryId = int.Parse(reader["category_id"].ToString()),
                                CategoryName = reader["name"].ToString(),
                                CreatedAt = DateTime.Parse(reader["created_at"].ToString())
                            };
                            foundBooks.Add(book);
                        }
                    }
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

            return foundBooks;
        }

        public List<Book> GetListBook()
        {
            string query = "select a.*,b.name from book a join category b on a.category_id=b.id";
            List<Book> bookList = new List<Book>();
            try
            {
                DBUtil.Instance.OpenConnection();
                using(SqlCommand command=new SqlCommand(query,DBUtil.Instance.Connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Book book = new Book
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Title = reader["title"].ToString(),
                                Price = float.Parse(reader["price"].ToString()),
                                ImageCover = (byte[])reader["image_cover"],
                                Rating = int.Parse(reader["rating"].ToString()),
                                Description = reader["description"].ToString(),
                                Author = reader["Author"].ToString(),
                                CategoryId = int.Parse(reader["category_id"].ToString()),
                                CategoryName = reader["name"].ToString(),
                                CreatedAt = DateTime.Parse(reader["created_at"].ToString())
                            };
                            bookList.Add(book);
                            
                        }

                    }
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
            return bookList;
        }

        public List<Book> FindBookByCategoryId(int categoryId)
        {
            List<Book> bookList = new List<Book>();
            string query = "select * from book a join category b on a.category_id=b.id where a.category_id=@categoryId";
            try
            {
                DBUtil.Instance.OpenConnection();   
                SqlCommand sql=new SqlCommand(query,DBUtil.Instance.Connection);
                sql.Parameters.AddWithValue("@categoryId", categoryId);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Book book = new Book
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        Title = reader["title"].ToString(),
                        Price = float.Parse(reader["price"].ToString()),
                        ImageCover = (byte[])reader["image_cover"],
                        Rating = int.Parse(reader["rating"].ToString()),
                        Description = reader["description"].ToString(),
                        Author = reader["Author"].ToString(),
                        CategoryId = int.Parse(reader["category_id"].ToString()),
                        CategoryName = reader["name"].ToString(),
                        CreatedAt = DateTime.Parse(reader["created_at"].ToString())
                    };
                    bookList.Add(book);
                }

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { DBUtil.Instance.Close(); }
            return bookList;

        }

        public List<Book> FindBookByPrice(float min,float max)
        {
            
            List<Book> bookList = new List<Book>();
            string query = "select * from book a join category b on a.category_id=b.id where a.price>=@min and a.price<=@max";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand sql = new SqlCommand(query, DBUtil.Instance.Connection);
                sql.Parameters.AddWithValue("@min", min);
                sql.Parameters.AddWithValue("@max", max);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Book book = new Book
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        Title = reader["title"].ToString(),
                        Price = float.Parse(reader["price"].ToString()),
                        ImageCover = (byte[])reader["image_cover"],
                        Rating = int.Parse(reader["rating"].ToString()),
                        Description = reader["description"].ToString(),
                        Author = reader["Author"].ToString(),
                        CategoryId = int.Parse(reader["category_id"].ToString()),
                        CategoryName = reader["name"].ToString(),
                        CreatedAt = DateTime.Parse(reader["created_at"].ToString())
                    };
                    bookList.Add(book);
                }

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { DBUtil.Instance.Close(); }
            return bookList;
        }

        public List<Book> findBookByCategoryAndPrice(int categoryId, float min, float max)
        {
            List<Book> bookList = new List<Book>();
            string query = "select * from book a join category b on a.category_id=b.id where a.price>=@min and a.price<=@max and a.category_id=@categoryId";
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand sql = new SqlCommand(query, DBUtil.Instance.Connection);
                sql.Parameters.AddWithValue("@min", min);
                sql.Parameters.AddWithValue("@max", max);
                sql.Parameters.AddWithValue("@categoryId", categoryId);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Book book = new Book
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        Title = reader["title"].ToString(),
                        Price = float.Parse(reader["price"].ToString()),
                        ImageCover = (byte[])reader["image_cover"],
                        Rating = int.Parse(reader["rating"].ToString()),
                        Description = reader["description"].ToString(),
                        Author = reader["Author"].ToString(),
                        CategoryId = int.Parse(reader["category_id"].ToString()),
                        CategoryName = reader["name"].ToString(),
                        CreatedAt = DateTime.Parse(reader["created_at"].ToString())
                    };
                    bookList.Add(book);
                }

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { DBUtil.Instance.Close(); }
            return bookList;
        }

        public bool CreateBook(Book book)
        {

            string query = "insert into book (title,price,image_cover,rating,description,author,category_id,created_at)" +
                " values (@title,@price,@imageCover,@rating,@description,@author,@categoryId,@createdAt)";

            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand cmd = new SqlCommand(query,DBUtil.Instance.Connection);
                cmd.Parameters.AddWithValue("@title", book.Title);
                cmd.Parameters.AddWithValue("@price", book.Price);
                cmd.Parameters.AddWithValue("@imageCover", book.ImageCover);
                cmd.Parameters.AddWithValue("@description", book.Description);
                cmd.Parameters.AddWithValue("@author", book.Author);
                cmd.Parameters.AddWithValue("@rating", book.Rating);
                cmd.Parameters.AddWithValue("@categoryId", book.CategoryId);
                cmd.Parameters.AddWithValue("@createdAt", book.CreatedAt);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;   
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                DBUtil.Instance.Close();
            }
        }




        public bool UpdateBook(Book updatedBook,int id)
        {
            string query = "UPDATE book SET title = @title, price = @price, image_cover = @imageCover, " +
                           "rating = @rating, description = @description, author = @author, " +
                           "category_id = @categoryId WHERE id = @bookId";

            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, DBUtil.Instance.Connection);
                cmd.Parameters.AddWithValue("@bookId", id);
                cmd.Parameters.AddWithValue("@title", updatedBook.Title);
                cmd.Parameters.AddWithValue("@price", updatedBook.Price);
                cmd.Parameters.AddWithValue("@imageCover", updatedBook.ImageCover);
                cmd.Parameters.AddWithValue("@description", updatedBook.Description);
                cmd.Parameters.AddWithValue("@author", updatedBook.Author);
                cmd.Parameters.AddWithValue("@rating", updatedBook.Rating);
                cmd.Parameters.AddWithValue("@categoryId", updatedBook.CategoryId);
                int rowsAffected = cmd.ExecuteNonQuery();

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


        public bool DeleteBook(string id)
        {
            string query = "delete from book where id=" + id;
            try
            {
                DBUtil.Instance.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, DBUtil.Instance.Connection);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }finally { DBUtil.Instance.Close(); }
        }
    }
}
