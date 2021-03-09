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
    public class EditModel : PageModel
    {
        private readonly IUserData userData;

        [BindProperty]
        public User _user { get; set; }

        public EditModel(IUserData data)
        {
            userData = data;
        }

        public IActionResult OnGet(int? userId)
        {
            if (userId.HasValue)
            {
                _user = userData.GetById(userId.Value);

                if (_user != null)
                {
                    return Page();
                }
                else
                {
                    return RedirectToPage("./List");
                }
            }
            else
            {
                return RedirectToPage("./List");
            }
        }

        public IActionResult OnPost()
        {
            userData.Update(_user);
            return RedirectToPage("./List");
        }
    }
}
