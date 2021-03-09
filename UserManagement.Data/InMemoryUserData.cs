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
                new User { Id = 1, Name = "Tom" },
                new User { Id = 2, Name = "Kelly" }
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

        public User Update(User updatedUser)
        {
            var user = users.SingleOrDefault(user => user.Id == updatedUser.Id);
            if (user != null)
            {
                user = updatedUser;
            }
            return user;
        }

        public User GetById(int id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }

    }
}
