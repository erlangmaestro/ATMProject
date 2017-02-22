using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            List<Movie> movies = new List<Movie> { new Movie { Name = "Predator", Id = 1}, new Movie { Name = "Alien", Id = 2 },
                new Movie { Name = "Finding Nemo", Id = 3 }, new Movie { Name = "Blackjack", Id = 4 } };
            ViewBag.MyList = movies;
            return View();
        }
    }
}