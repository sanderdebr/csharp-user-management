using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserManagement.Core;
using UserManagement.Data;

namespace UserManagement.Pages.Users
{
    public class UserModel : PageModel
    {
        public User User { get; set; }

        private readonly IUserData _data;

        public UserModel(IUserData data)
        {
            _data = data;
        }

        public IActionResult OnGet(int userId)
        {
            User = _data.GetById(userId);
            if (User == null)
            {
                return RedirectToPage("/Users/List");
            }
            return Page();
        }
    }
}
