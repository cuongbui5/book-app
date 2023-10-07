using Book_App.Models;
using Book_App.Repository;
using System;
using System.Transactions;


namespace Book_App.Services
{
    class AuthService
    {
        private static AuthService instance;

        public static AuthService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthService();
                }
                return instance;
            }
        }

        public bool Register(string username, string password)
        {

            User newUser = new User();
            newUser.UserName = username;
            newUser.Password = password;
            newUser.Role = "USER";
            using(TransactionScope transaction =new TransactionScope())
            {
                string userId = UserRepository.Instance.CreateUser(newUser);
                if (string.IsNullOrEmpty(userId))
                {
                    throw new Exception("Create user fail!");

                }
                else
                {
                    bool createCart = CartService.Instance.CreateCart(userId);
                    if (createCart)
                    {
                       
                        transaction.Complete(); 
                        return true;
                       
                    }
                    transaction.Dispose();
                    return false;



                }
              
            }
            

        }

        public User Login(string usename,string password) {
            User user = UserRepository.Instance.FindUserByUsername(usename);        
            if (password != user.Password)
            {
                throw new Exception("Account or password is incorrec!Please login again!");
            }
            if (user.IsLocked)
            {
                throw new Exception("Account has been locked!");
            }
            
            return user;
           
        }
    }
}
