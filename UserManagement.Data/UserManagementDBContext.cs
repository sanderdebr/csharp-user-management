using Microsoft.EntityFrameworkCore;
using UserManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Data
{
    public class UserManagementDBContext : DbContext
    {
        public UserManagementDBContext(DbContextOptions<UserManagementDBContext> options) : base(options)
        {
            //
        }

        public DbSet<User> Users { get; set; }
    }
}
