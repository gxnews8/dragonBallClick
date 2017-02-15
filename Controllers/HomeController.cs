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
            System.Console.WriteLine("Krillins the hommie. He helps you train and makes you 1.5X more efficient in the power up department");
            return View();
        }
        [HttpPost]
        [Route("/add/vegetta")]
        public IActionResult Vegetta(){
            System.Console.WriteLine("This is Vegetta. Vegetta is very rude. We tolerate him because hes technically a prince. Hes pretty competetive so he makes you 3X faster @ powering up");
            return View();
        }
        [HttpPost]
        [Route("/add/masterRoshi")]
        public IActionResult MasterRoshi(){
            System.Console.WriteLine("Master Roshi has a beard and a crude taste in novels. Hes the day 1 ride or die, been working with you from the word go. he doubles your potential");
            return View();
        }
        [HttpPost]
        [Route("/add/cell")]
        public IActionResult Cell(){
            System.Console.WriteLine("Cell is very shallow and pedantic. Hes a pretty cut and dry bad guy. For some reason he wants to train with you and he makes you power up 3.5 times as fast");
            return View();
        }
        [HttpPost]
        [Route("/add/shenLong")]
        public IActionResult ShenLong(){
            System.Console.WriteLine("Shen Long is the ancient dragon genie of the dragon balls. He will trade you wishes for balls at a 1 to 7 exchange rate. he makes you power up 9002 times faster!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            return View();
        }
    }
}
