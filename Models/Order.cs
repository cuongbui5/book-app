using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_App.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public float Total { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public Order() { }
    }
}
