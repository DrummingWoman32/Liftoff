using Liftoff.Data;
using Liftoff.Models;
using Liftoff.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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
            //AccountModel am = new AccountModel();

            /*if ((string.IsNullOrEmpty(loginViewModel.Username) && string.IsNullOrEmpty(loginViewModel.Password))
                || (!string.IsNullOrEmpty(loginViewModel.Username) && string.IsNullOrEmpty(loginViewModel.Password)
                || (string.IsNullOrEmpty(loginViewModel.Username) && (!string.IsNullOrEmpty(loginViewModel.Password)))))*/

            /*if (string.IsNullOrEmpty(avm.Account.username) || string.IsNullOrEmpty(avm.Account.password)
                || am.login(avm.Account.username, avm.Account.password) == null)*/

            /*if (string.IsNullOrEmpty(loginViewModel.Username) || string.IsNullOrEmpty(loginViewModel.Password)
                || am.login(loginViewModel.Username, loginViewModel.Password) == null)*/

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
                    /*if (HttpContext.Current == null || HttpContext.Current.Session == null ||
                        HttpContext.Current.Session["ID"] == null)*/
                        //Session["ID"] = accountDetails.ID;
                        //HttpContext.Current.Session["accountID"] = accountDetails.ID;

                        //string str = HttpContext.Current.Session["accountID"].ToString();
                        //return RedirectToAction("AccountHomePage", "Account");

                    Account loggedInAccount = new Account
                    {
                        username = loginViewModel.Username,
                        password = loginViewModel.Password

                    };

                    return Redirect("/Account/AccountHomePage/" + loggedInAccount.ID);
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

        //this will be for the page where the user searches for businesses that they pitched
        //or will pitch
        public IActionResult BizSearch(string searchBy, string search)
        {
            //I have no table named Businesses that holds the info of businesses yet,
            //so it looks like I need that, obviously

            /*if(searchBy == "Name")
            {
                return View(context.Businesses.Where(x => x.name.StartsWith(search) || search == null).ToList());
            }
            else if(searchBy == "Building number")
            {
                return View(context.Businesses.Where(x => x.address_number == search || search == null).ToList());
            }
            else if(searchBy == "Street")
            {
                return View(context.Businesses.Where(x => x.street.StartsWith(search) || search == null).ToList());
            }

            else
            {
                return View();
            }*/


            return View();
        }

    }
}
