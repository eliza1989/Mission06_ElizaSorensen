using Mission06_Sorensen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult MovieForm(Film response) {

            _context.Films.Add(response);
            _context.SaveChanges();

            return View("Thanks", response);

        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }




    }
}
