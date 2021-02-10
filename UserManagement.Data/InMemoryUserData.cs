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
            var name = "";

            return from r in users
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r; ;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
