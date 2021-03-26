using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Core
{
    public class User
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required, StringLength(255)]
        public string Email { get; set; }
    }
}
