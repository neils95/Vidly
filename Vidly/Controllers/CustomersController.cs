using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private IEnumerable<Customer> customers = new List<Customer>
        {
            new Customer {Id=1, Name="Neil Sanghrajka" },
            new Customer {Id=2, Name="Disha Sanghrajka"}

        };

        // GET: Customers must return a list of all customers
        public ActionResult Index()
        {
            return View("Index", customers);
        }

        //Get: Customers/Details/{customerId}
        [Route("Customers/details/{customerId:int:regex(1|2)}")]
        public ActionResult Details(int customerId)
        {
            return View("Details", customers.SingleOrDefault(c => c.Id == customerId));
        }

    }
}