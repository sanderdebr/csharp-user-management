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
    public class SearchModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        public string Message { get; set; }
        private readonly IUserData _data;

        public SearchModel(IUserData data)
        {
            _data = data;
        }

        public IActionResult OnGet()
        {
            User = new User();
            return Page();
        }

        public IActionResult OnPost()
        {
            var users = _data.GetAllUsers();
            var result = users.FirstOrDefault(user => user.Name == User.Name);

            if (result != null)
            {
                return RedirectToPage("/Users/User");
            }

            Message = "User not found";
            return Page();
        }
    }
}
