using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dragonBallClick.Controllers
{
    public class HomeController : Controller
    {
        // Index. Creates a new Player object, named Goku.
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        // Powers Goku up using the Power Button
        [HttpPost]
        [Route("/click")]
        public IActionResult Click()
        {
            System.Console.WriteLine("POWER UUUUUUPPPP");
            return View();
        }
        [HttpPost]
        [Route("/add/krillin")]
        public IActionResult Krillin(){
            System.Console.WriteLine("Krillins the hommie. He helps you train and makes you 1.5X more efficient");
            return View();
        }
    }
}
