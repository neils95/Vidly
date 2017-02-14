using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

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
			//Eager loading using Inlclude()
			var customers = _context.Customers.Include(c => c.MembershipType).ToList();
			return View("Index", customers);
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