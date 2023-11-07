using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_App.Models
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public byte[] ImageCover { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }    
        public string Author { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedAt { get; set; }
        public override string ToString()
        {
            return $"ID: {Id}\nTitle: {Title}\nPrice: {Price}\nRating: {Rating}\nDescription: {Description}\nAuthor: {Author}\nCategory ID: {CategoryId}\nCreated At: {CreatedAt}";
        }



       
    }
}
