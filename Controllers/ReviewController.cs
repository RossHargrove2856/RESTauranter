using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RESTaurant.Models;

namespace RESTaurant.Controllers
{
    public class ReviewController : Controller
    {
        private RestaurantContext _context;
        public ReviewController(RestaurantContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/Reviews")]
        public IActionResult AllReviews()
        {
            ViewBag.AllReviews = _context.Users.ToList().OrderByDescending(review => review.date_of_visit);
            return View("Reviews");
        }
        [HttpGet]
        [Route("/Create")]
        public IActionResult CreateReview()
        {
            return View("Create");
        }

        [HttpPost]
        [Route("/Create")]
        public IActionResult AddReview(ReviewViewModel model)
        {
            if(ModelState.IsValid)
            {
                Review newReview = new Review
                {
                    name = model.name,
                    restaurant_name = model.restaurant_name,
                    stars = model.stars,
                    review = model.review,
                    date_of_visit = model.date_of_visit
                };
                _context.Add(newReview);
                _context.SaveChanges();
                return RedirectToAction("AllReviews");
            }
            return View("Create", model);
        }
    }
}