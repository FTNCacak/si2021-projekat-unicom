using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBusiness
    {
        readonly UserRepository userRepository = new UserRepository();

        public List<User> GetUsers()
        {
            return userRepository.GetAllUsers().ToList();
        }

        public bool InsertUsers(User user)
        {
            return userRepository.InsertUser(user) != 0;
        }
    }
}
