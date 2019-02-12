using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liftoff.Data;
using Microsoft.AspNetCore.Mvc;
using Liftoff.ViewModels;
using Microsoft.EntityFrameworkCore;
using Liftoff.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Liftoff.Controllers
{
    public class TrackingSheetController : Controller
    {
        private AccountDbContext context;

        public TrackingSheetController(AccountDbContext dbContext)
        {
            context = dbContext;
        }



        // GET: /<controller>/
        public IActionResult Index()
        {
            //so i guess here i would list all the user's previous tracking sheets, 
            //as well as their current one

            List<TrackingSheet> trackingSheets = context.TrackingSheets.ToList();
            return View(trackingSheets);
        }

        //new tracking sheet for when user needs one
        public IActionResult newTrackingSheet()
        {
            return View();
        }
    }
}
