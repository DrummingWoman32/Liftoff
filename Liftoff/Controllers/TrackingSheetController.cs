using System.Collections.Generic;
using System.Linq;
using Liftoff.Data;
using Microsoft.AspNetCore.Mvc;
using Liftoff.ViewModels;
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

        //i just recalled every model needs crud operations: create, read, update, delete


        // GET: /<controller>/
        public IActionResult Index()
        {
            //so i guess here i would list all the user's previous tracking sheets, 
            //as well as their current one

            //i think right now this would get all the tracking sheets in the app, rather than just one user's
            List<TrackingSheet> trackingSheets = context.TrackingSheets.ToList();
            return View(trackingSheets);
        }

       
        //I think I'd better create a ViewModel for the tracking sheet model
        

        [HttpGet]
        public IActionResult newTrackingSheet() //create new tracking sheet
        {
            AddTSViewModel addTSViewModel = new AddTSViewModel();
            return View();
        }

        //new tracking sheet for when user needs one
        //create() or new()
        /*if new method, get request, form page
        if create method, form handler, post
         */
        [HttpPost]
        public IActionResult newTrackingSheet(AddTSViewModel addTSViewModel)
        {
            //when the user creates a new tracking sheet, he/she needs the option of 
            //either saving the sheet or deleting it
            //if save the sheet, sheet needs to be saved in database

            //this code below would most apply if the user wanted to save
            //the tracking sheet

            List<Business> businesses = new List<Business>();

            if (ModelState.IsValid)
            {
                TrackingSheet newTrackingSheet = new TrackingSheet
                {
                    date = addTSViewModel.date,
                    //businesses = newTrackingSheet.businesses;
                    //username = addTSViewModel.username
                };

                context.TrackingSheets.Add(newTrackingSheet);
                context.SaveChanges();
                
            }

            return View(businesses);
        }

    }
}
