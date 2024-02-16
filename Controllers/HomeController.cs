using _6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _6.Controllers
{
    public class HomeController : Controller
    {
        



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieForm()
        {
            return View();  
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }




    }
}
