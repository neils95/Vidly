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
        private ApplicationDbContext _context;

        public CustomersController()
        {
            //Initialize DbContext in constructor
            _context = new ApplicationDbContext();
        }

        // GET: Customers must return a list of all customers
        public ActionResult Index()
        {
            return View("Index", _context.Customers.ToList());
        }

        //Get: Customers/Details/{customerId}
        [Route("Customers/details/{customerId:int:regex(1|2)}")]
        public ActionResult Details(int customerId)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == customerId);
            if (customer == null)
                return HttpNotFound();

            return View("Details", customer);
        }

    }
}