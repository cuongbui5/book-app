using Book_App.Models;
using Book_App.Repository;
using System.Collections.Generic;
using System.Data;


namespace Book_App.Services
{
    class BookService
    {
        private static BookService instance;
        public static BookService Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new BookService();
                }
                return instance;
            }
        }

        public List<Book> FilterBookByPrice(float min,float max)
        {
            return BookRepository.Instance.FindBookByPrice(min,max);
        }
        public List<Book> FilterBookByCategoryId(int categoryId)
        {
            return BookRepository.Instance.FindBookByCategoryId(categoryId);
        }
        public List<Book> FilterBookByCategoryIdAndPrice(int categoryId, float min, float max)
        {
            return BookRepository.Instance.findBookByCategoryAndPrice(categoryId,min,max);
        }

        public bool CreateBook(Book book)
        {
           
            return BookRepository.Instance.CreateBook(book);

        }


        public List<Book> FindBooksByTitle(string title)
        {
            return BookRepository.Instance.FindBooksByTitle(title);
        }

        public List<Book> GetListBook() { 

            return BookRepository.Instance.GetListBook();
        }

        public bool UpdateBook(Book book,int id)
        {
            return BookRepository.Instance.UpdateBook(book, id);


        }

        public bool DeleteBook(string id)
        {
            return BookRepository.Instance.DeleteBook(id);
        }

        public DataSet LoadDataSetBooks()
        {
            return BookRepository.Instance.GetAllBooks();
        }
       
    }
}
