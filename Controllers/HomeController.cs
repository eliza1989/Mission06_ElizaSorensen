using Mission06_Sorensen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mission06_Sorensen.Controllers
{
    public class HomeController : Controller
    {
        



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

            return View("Thanks", response);

        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }




    }
}
