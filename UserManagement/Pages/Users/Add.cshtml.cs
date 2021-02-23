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
    public class AddModel : PageModel
    {
        private readonly IUserData userData;

        [BindProperty]
        public User User { get; set; }

        public AddModel(IUserData userData)
        {
            this.userData = userData;
        }

        public IActionResult OnGet()
        {
            User = new User()
            {
                Id = 1
            };
            return Page();
        }

        public IActionResult OnPost()
        {
            userData.Add(User);
            userData.Commit();
            return RedirectToPage("./List");
        }
    }
}
