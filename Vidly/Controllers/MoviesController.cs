using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;
using System.Linq;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
		private ApplicationDbContext _context { get; set; }

		public MoviesController()
		{
			_context = new ApplicationDbContext();
		}
										   
		//GET: Movies
		public ActionResult Index()
        {
			var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View("Index", movies);
        }


		//GET: Movies/{movieId}
		[Route("Movies/details/{movieId:int}")]
		public ActionResult Details(int movieId)
		{
			var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == movieId);
			if (movie == null)
				return HttpNotFound();

			return View("Details", movie);
		}








	}
}