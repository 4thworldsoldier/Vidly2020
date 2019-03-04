﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2020.Models;
using Vidly2020.ViewModels;

namespace Vidly2020.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index( int? pageindex, string sortby)
        {
            //if(!pageindex.HasValue)
            return View();
        }

        public ActionResult Edit(int id)
        {

            return View();
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "shrek!" };
            var customers = new List<Customer>
            {
                new Customer{Name = "Customer 1"},
                new Customer{Name = "Customer 2"}
            };
            var viewmodel = new RandomMovieViewModels
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewmodel);
        }

    }
}