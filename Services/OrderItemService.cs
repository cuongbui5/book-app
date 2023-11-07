using Book_App.Models;
using Book_App.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_App.Services
{
    class OrderItemService
    {
        private static OrderItemService instance;

        public static OrderItemService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderItemService();
                }
                return instance;
            }
        }

        public void CreateOrderItem(OrderItem orderItem)
        {
            if (!OrderItemRepository.Instance.CreateOrderItem(orderItem))
            {
                throw new Exception("Create order item fail!");
            }
        }

        public List<OrderItem> GetOrderItemsByOrderId(string orderId) {
            return OrderItemRepository.Instance.GetOrderItemsByOrderId(orderId);


        }
    }
}
