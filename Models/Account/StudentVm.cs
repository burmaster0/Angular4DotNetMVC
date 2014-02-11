using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Angular4DotNetMvc.Models.Account
{
    public class StudentVm
    {
        [Required(ErrorMessage="Please enter your first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a password")]
        public string Password { get; set; }
    }
}