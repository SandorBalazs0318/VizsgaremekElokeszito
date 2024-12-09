using GlobeTrekker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GlobeTrekker.Repositories
{
    public class UserRepository
    {
        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser = true;
            return validUser;
        }

        public User? GetByUsername(string userName)
        {
            return new User
            {
                Username = "teszt",
                Email = "teszt@teszt.hu",
                FirstName = "Elek",
                LastName = "Teszt",
                Password = "test@123"
            };
        }
    }
}
