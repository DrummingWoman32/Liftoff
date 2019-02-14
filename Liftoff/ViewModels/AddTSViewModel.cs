using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Liftoff.ViewModels
{
    public class AddTSViewModel
    {
        //tracking sheet carries date it's created and list of
        //businesses
        [Required]
        [Display(Name = "Date")]
        public string date { get; set; }

        //public string username { get; set; }


    }
}
