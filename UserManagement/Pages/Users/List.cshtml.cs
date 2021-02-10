using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserManagement.Core;
using UserManagement.Data;

namespace UserManagement.Pages
{
    public class ListModel : PageModel
    {
        private readonly IUserData userData;

        public IEnumerable<User> Users { get; set; }

        public ListModel(IUserData userData)
        {
            this.userData = userData;
        }

        public void OnGet()
        {
            Users = userData.GetAllUsers();
        }
    }
}
