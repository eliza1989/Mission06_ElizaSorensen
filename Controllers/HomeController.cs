using Mission06_Sorensen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using _6.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

//add actions and context that create instances of the database, add actions to display views, and add and save responses to the database
namespace Mission06_Sorensen.Controllers
{
    public class HomeController : Controller
    {

        private MovieFormContext _context;
        public HomeController(MovieFormContext temp)//constructor
        {
            _context = temp;
        }

        //Return the Index View
        public IActionResult Index()
        {
            return View();
        }


        //Return the Movie form with a new movie instance
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = _context.Category.ToList();
            return View("MovieForm", new Movies());  
        }


        //Make sure input is valid and add and save if it is and return error messages if invalid
        [HttpPost]
        public IActionResult MovieForm(Movies response) {
           

            if (ModelState.IsValid)
                {
                    _context.Movies.Add(response);
                    _context.SaveChanges();

                    return View("Thanks", response);
                }
            else
            {
                ViewBag.Categories = _context.Category.ToList();
                return View(response);
            }
        }


        //Return the get to know joel view
        public IActionResult GetToKnowJoel()
        {
            return View();
        }


        //Return all the movies with their category name
        [HttpGet]
        public IActionResult MovieList()
        {
            var allMovieList = _context.Movies.Include("Category").ToList();


            return View(allMovieList);

        }

        //allow them to go in and edit the desired record
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Category.ToList();

            return View("MovieForm", recordToEdit);
        }


        //allow users to submit and save updated info if the data is valid and alert if invalid
        [HttpPost]
        public IActionResult Edit(Movies updatedInfo)
        {

            if (ModelState.IsValid)
            {
                _context.Update(updatedInfo);
                _context.SaveChanges();

                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = _context.Category.ToList();
                return View("MovieForm", updatedInfo);
            }
        }


        //Allow user to delet a particular record
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var deleteMovie = _context.Movies
                .Single(x => x.MovieId == id);

            return View(deleteMovie);
        }


        //Save Delete
        [HttpPost]
        public IActionResult Delete(Movies Movies)
        {
            _context.Movies.Remove(Movies);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
