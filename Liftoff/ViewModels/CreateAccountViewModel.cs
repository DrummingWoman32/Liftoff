﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liftoff.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Liftoff.ViewModels
{
    public class CreateAccountViewModel
    {
        [Required]
        [Display(Name = "Type in a username: ")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Type in a password: ")] //i want the passwords to be minimum 5 chars long, but later
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Required(ErrorMessage = "Passwords don't match up")]
        //[Display(Name = "Confirm password: ")]
        [Required]
        [Display(Name = "Confirm password: ")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Type in or select the area code where you pitch businesses.")]
        public int areaCode { get; set; }
        //okay, so here I would need all the zipcodes of all the united states...i don't know how to get all of those
        //coded here, but I do know this would probably call for an IEnumerable of zipcodes and then a SelectListItem


        [Required]
        [Display(Name = "Type in your source code. ")]
        public int sourceCode { get; set; }

        public List<SelectListItem> Zipcodes { get; set; }

        public CreateAccountViewModel(IEnumerable<int> zipcodes)
        {
            Zipcodes = new List<SelectListItem>();

            foreach (int zipcode in zipcodes)
            {
                Zipcodes.Add(new SelectListItem
                {
                    Value = zipcode.ToString(),
                    Text = zipcode.ToString()
                });
            }
        }

        public CreateAccountViewModel()
        {
            //default constructor
        }



    }
}
