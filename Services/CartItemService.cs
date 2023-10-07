using Book_App.Models;
using Book_App.Repository;
using System.Collections.Generic;

namespace Book_App.Services
{
     class CartItemService
    {
        private static CartItemService instance;

        public static CartItemService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CartItemService();
                }
                return instance;
            }
        }


        public bool UpdateQuantityByCartId(string quantity,int cartId)
        {
            return CartItemRepository.Instance.UpdateCartItemById(quantity,cartId);
        }
        public float GetTotalPriceByCartId(int cartId)
        {
            return CartItemRepository.Instance.GetTotalPriceByCartId(cartId);
        }

        public bool CreateCartItem(CartItem cartItem)
        {
            return CartItemRepository.Instance.CreateCartItem(cartItem);
        }

        public List<CartItem> GetCartItemsByCartId(int cartId) {
            return CartItemRepository.Instance.GetCartItemsByCartId(cartId);
        }

        public bool DeleteCartItemByCartId(int cartId)
        {
            return CartItemRepository.Instance.DeleteCartItemByCartId(cartId) ;
        }

        public bool DeleteCartItem(int cartItemId)
        {
            return CartItemRepository.Instance.DeleteCartItemById(cartItemId);
        }
    }
}
