using Book_App.Models;
using Book_App.Repository;
using System.Data;


namespace Book_App.Services
{
    class OrderService
    {
        private static OrderService instance;
        public static OrderService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderService();
                }
                return instance;
            }
        }

        public string CreateOrder(Order order)
        {

            return OrderRepository.Instance.CreateOrder(order);
        }

        public DataSet GetOrdersByUserId(int userId)
        {
            return OrderRepository.Instance.GetOrdersByUserId(userId);
        }


    }
}
