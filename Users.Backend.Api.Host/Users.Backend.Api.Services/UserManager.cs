using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Backend.Api.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Users.Backend.Api.Models;

    public class UserManager : IUserManager
    {
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Kunal Bathija", Email = "kunal.bathija@example.com" },
            new User { Id = 2, Name = "Test User", Email = "test.user@example.com" }
        };

        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        public User GetUser(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }

        public string GetUserDomain(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);

            var match = Regex.Match(user.Email, @"@(?<domain>.+)$");

            var domain = match.Groups["domain"].Value;

            if (domain == "rxo")
            {
                return "User is from RXO Inc";
            }
            if(domain == "xpo")
            {
                return "User is from XPO Logistics";
            }
            if(domain == "infosys")
            {
                return "User is from Infosys";
            }
            if (domain == "google")
            {
                return "User is from Google";
            }
            if (domain == "facebook")
            {
                return "User is from Infosys";
            }
            if (domain == "microsoft")
            {
                return "User is from Microsoft";
            }
            if (domain == "somecompany")
            {
                return "User is from Somecompany";
            }

            return "";
        }

        public User CreateUser(User newUser)
        {
            newUser.Id = users.Max(u => u.Id) + 1;
            users.Add(newUser);
            return newUser;
        }

        public bool UpdateUserEmailIfMissing(int id, User updatedUser)
        {
            var user = users.FirstOrDefault(u => u.Id == id);


            if(string.IsNullOrEmpty(user.Email))
                user.Email = updatedUser.Email;

            return true;
        }

        public bool DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);

            users.Remove(user);
            return true;
        }

        public bool SomeMethodWhichIsNotUsed(User user)
        {
            int x = 0;
            while (true)
                x = x + 1;
        }
    }

}
