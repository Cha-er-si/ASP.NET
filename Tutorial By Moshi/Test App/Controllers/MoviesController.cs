using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_App.Models;
using Test_App.ViewModels;

namespace Test_App.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };

            //ViewData["Movie"] = movie;

            //var viewResult = new ViewResult();
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            // return Content("Hello World!");
            // return HttpNotFound(); 
            // return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1; 
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}