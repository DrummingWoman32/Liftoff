using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liftoff.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace Liftoff.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [Display(Name = "Type in your username: ")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Type in a new password: ")] //i want the passwords to be minimum 5 chars long, but later
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required]
        [Display(Name = "Confirm new password: ")]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }

        public ForgotPasswordViewModel()
        {
            //default constructor
        }
    }
}
