using Book_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_App.Util
{
    class MapperClass
    {
        public static OrderItem CartItemToOrderItem(CartItem cartItem)
        {
            var orderItem = new OrderItem();
            orderItem.Quantity = cartItem.Quantity;
            orderItem.BookId = cartItem.BookId;
            orderItem.Price = cartItem.Quantity * cartItem.Book.Price;
            return orderItem;

        }
    }
}
