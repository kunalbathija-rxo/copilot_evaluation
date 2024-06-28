using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Backend.Api.Models;

namespace Users.Backend.Api.Services
{
    public interface IUserManager
    {
        User CreateUser(User newUser);
        bool DeleteUser(int id);
        User GetUser(int id);
        string GetUserDomain(int id);
        IEnumerable<User> GetUsers();
        bool UpdateUserEmailIfMissing(int id, User updatedUser);
    }
}
