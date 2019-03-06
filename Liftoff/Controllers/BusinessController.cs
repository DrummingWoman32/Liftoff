using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Liftoff.Controllers
{
    public class BusinessController : Controller
    {
        [EnableCorsAttribute("https://localhost:44368", "*", "*")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            //var companies = DataRepository.GetCompanies();
            //hmmm...I think I need a file or something that would
            //have info of all small to medium sized businesses as
            //well as franchises that get their business supplies on their own

            //return View(companies);



            return View();
        }

        //this will be for the page where the user searches for businesses that they pitched
        //or will pitch
        [HttpGet]
        public IActionResult BizSearch()
        {
            return View();
        }

        
        [HttpPost]
        //public IActionResult BizSearch(string searchBy, string search)
        //[HttpGet]
        public IActionResult BizSearch(string searchText)
        {
            //I have no table named Businesses that holds the info of businesses yet,
            //so it looks like I need that, obviously

            //actually i'm implementing an api for this one

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


            return View(searchText);
        }

        /*public string DeleteData(int id) 
         {
            try
           {
                var company = 
                    DataRepository.GetCompanies().FirstOrDefault(c => c.ID == id);
                if (company == null)
                    return "Company cannot be found";
                DataRepository.GetCompanies().Remove(company);
                return "ok";
          }
            catch (Exception ex)
            {
                return ex.Message;
            }
         }
         */
        /*public string UpdateData(int id, string value, int? rowId,
               int? columnPosition, int? columnId, string columnName)
        {
            //var companies = DataRepository.GetCompanies();

            if (columnPosition == 0 && companies.Any(
                  c => c.Name.ToLower().Equals(value.ToLower())))
            return "Company with a name '" + value + "' already exists";
            var company = companies.FirstOrDefault(c => c.ID == id);
            if (company == null)
            {
               return "Company with an id = " + id + " does not exists";
            }
            switch (columnPosition)
            {
                case 0:
                     company.Name = value;
                     break;
                case 1:
                     company.Address = value;
                     break;
                case 2:
                     company.Town = value;
                     break;
                default:
                     break;
            }
           return value;
        }*/

        /*public int AddData(string name, string address, string town, int? country)
        {
            var companies = DataRepository.GetCompanies();
        if (companies.Any(c => c.Name.ToLower().Equals(name.ToLower())))
        {
            Response.Write("Company with the name '" + name + "' already exists");
            Response.StatusCode = 404;
            Response.End();
            return -1;
        }

        var company = new Company();
        company.Address = address;
        company.Name = name;
        company.Town = town;
        companies.Add(company);
        return company.ID;
        }*/

        /* form for adding data in a tracking sheet:
         * 
         * <form id="formAddNewRow" action="#" title="Add new company">
    <label for="name">Name</label><input type="text" 

       name="name" id="name" class="required" rel="0" />
    <br />
    <label for="name">Address</label><input type="text" 

       name="address" id="address" rel="1" />
    <br />
    <label for="name">Postcode</label><input 

       type="text" name="postcode" id="postcode"/>
    <br />
    <label for="name">Town</label><input 

       type="text" name="town" id="town" rel="2" />
    <br />
    <label for="name">Country</label>
        <select name="country" id="country">
            <option value="1">Serbia</option>
            <option value="2">France</option>
            <option value="3">Italy</option>
        </select>
    <br />
</form>
         */
    }
}
