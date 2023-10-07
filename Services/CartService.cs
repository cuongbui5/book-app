using Book_App.Models;
using Book_App.Repository;


namespace Book_App.Services
{
    class CartService
    {
        private static CartService instance;

        public static CartService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CartService();
                }
                return instance;
            }
        }

        public Cart GetCartByUserId(int userId)
        {
            return CartRepository.Instance.GetCartByUserId(userId); 
        }

        

        public bool CreateCart(string userId)
        {          
            return CartRepository.Instance.CreateCart(userId);  
        }
    }
}
