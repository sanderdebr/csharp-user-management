using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;

namespace UserManagement.Data
{
    public class InMemoryUserData : IUserData
    {
        readonly List<User> users;

        public InMemoryUserData()
        {
            users = new List<User>()
            {
                new User { Id = 1, Name = "Tom" }
            };
        }

        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public User Add(User user)
        {
            var newUser = new User()
            {
                Id = users.Count() + 1,
                Name = user.Name
            };
            users.Add(newUser);
            return newUser;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
