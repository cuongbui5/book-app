using Book_App.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_App.Services
{
    class UserService
    {
        private static UserService instance;

        public static UserService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserService();
                }
                return instance;
            }
        }

        public bool LockUserById(string userId)
        {
            return UserRepository.Instance.LockUser(userId);   
        }

        public DataSet GetAllUsers()
        {
            DataSet data=UserRepository.Instance.GetAllUsers();
            return data;
        }

        public bool DeleteUserById(int id)
        {
            return UserRepository.Instance.DeleteUserById(id);
        }
    }
}
