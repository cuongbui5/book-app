using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_App.Models
{
    class OrderItem
    {
        public int Id { get; set; }
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public float BookPrice{ get; set; }
        public byte[] BookImage { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
