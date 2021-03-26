using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;

namespace UserManagement.Data
{
    public class SQLUserData : IUserData
    {
        private readonly UserManagementDBContext _database;

        public SQLUserData(UserManagementDBContext database)
        {
            _database = database;
        }

        public User Add(User user)
        {
            _database.Add(user);
            return user;
        }

        public User Delete(int id)
        {
            var user = GetById(id);
            if (user != null)
            {
                _database.Users.Remove(user);
            }
            return user;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _database.Users.ToList();
        }

        public User GetById(int id)
        {
            return _database.Users.Find(id);
        }

        public int Save()
        {
            return _database.SaveChanges();
        }

        public User Update(User user)
        {
            var entity = _database.Users.Attach(user);
            entity.State = EntityState.Modified;
            return user;
        }
    }
}
