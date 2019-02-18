using Liftoff.Data;
using Liftoff.Models;
using Liftoff.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
//using System.Web.SessionState;
using System.Web;
//using System.Web.UI.WebControls;
using System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Liftoff.Controllers
{
    public class AccountController : Controller
    {
        private AccountDbContext context;

        public AccountController(AccountDbContext dbContext)
        {
            context = dbContext;
        }

        //all models need CRUD: create, read, update, delete

        // GET: /<controller>/
        //[HttpGet]
        public IActionResult Index()
        {
            //so the models for this app would be the account, the tracking sheets, the folders for the 
            //tracking sheets (?), the businesses that consultants visit

            //the controllers are actually named and organized by whatever model they are about

            return View();
        }

        //[HttpGet]
        //public IActionResult Index(AccountViewModel avm)

        [HttpPost]
        public IActionResult Index(LoginViewModel loginViewModel)
        {
            
            if (string.IsNullOrEmpty(loginViewModel.Username) || string.IsNullOrEmpty(loginViewModel.Password))
            {
                return View(loginViewModel);

                
            }



            //if user logged in correctly
            if (ModelState.IsValid)
            {

                var accountDetails = context.Accounts.Where(x => x.username == loginViewModel.Username &&
                x.password == loginViewModel.Password).FirstOrDefault();
                
                if(accountDetails == null)
                {
                    loginViewModel.LoginErrorMessage = "Wrong username or password.";
                    return View(loginViewModel);
                }

                else
                {
                   
                    //write to the session
                    HttpContext.Session.SetString("accountID", accountDetails.ID.ToString());

                    string strAccountID = HttpContext.Session.GetString("accountID");
                    //ID would be the ID of the account that is now logged in

                    //return Redirect("/Account/AccountHomePage/" + strAccountID);

                    return RedirectToAction("AccountHomePage", accountDetails);
                    
                  
                }




            }


            return View(loginViewModel);

            //the error messages are supposed to show when user doesn't log in correctly

        }

        public IActionResult CreateAccount()
        {
            CreateAccountViewModel createAccountViewModel = new CreateAccountViewModel();

            return View(createAccountViewModel);
        }

        //this is for actually processing the new user and his/her account
        [HttpPost]
        public IActionResult CreateAccount(CreateAccountViewModel createAccountViewModel)
        {


            if (string.IsNullOrEmpty(createAccountViewModel.Username) || string.IsNullOrEmpty(createAccountViewModel.Password)
                || string.IsNullOrEmpty(createAccountViewModel.ConfirmPassword) || (createAccountViewModel.areaCode == 0) ||
                createAccountViewModel.sourceCode == 0)
            {
                return View(createAccountViewModel);
            }

            if (ModelState.IsValid)
            {
                //create new user who just signed up
                Account newAccount = new Account
                {
                    username = createAccountViewModel.Username,
                    password = createAccountViewModel.Password,
                    areaCode = createAccountViewModel.areaCode,
                    sourceCode = createAccountViewModel.sourceCode,
                    trackingSheets = new List<TrackingSheet>()
                };

                //save to the database

                context.Accounts.Add(newAccount);
                context.SaveChanges();


                return Redirect("/Account/AccountConfirmation"); //this is just for now, while this part is still in development

            }

            return View(createAccountViewModel);
        }

        //this is for login confirmation
        //[HttpPost]
        public IActionResult AccountConfirmation()
        {
            return View();
        }



        //this is for user page when user first logs in or registers
        public IActionResult AccountHomePage(Account loggedInAccount)
        {
            return View(loggedInAccount);
        }

        

        //change password
        public IActionResult ForgotPassword()
        {
            //okay, so here the app would help the user change his or her password, whether they forgot it or didn't...
            
            return View("~/Areas/Identity/Pages/Account/ForgotPassword.cshtml");
        }

        //logout
        public IActionResult Logout()
        {
            //so here, I'd delete the session and then redirect the user to the login page
            //except that the session bug is still there. Let me do whatever I can here

            //Session.Remove("username");
            return Redirect("/Account/Index");
        
        }

    }
}
