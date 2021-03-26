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
    public class DeleteModel : PageModel
    {
        private readonly IUserData _userData;

        public User User { get; set; }

        public DeleteModel(IUserData userData)
        {
            _userData = userData;
        }

        public IActionResult OnGet(int userID)
        {
            User = _userData.GetById(userID);

            return Page();
        }

        public IActionResult OnPost(int userID)
        {
            var user = _userData.Delete(userID);
            _userData.Save();

            return RedirectToPage("./List");
        }
    }
}
