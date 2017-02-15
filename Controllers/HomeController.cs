using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
            Player goku = new Player();
            return View();
        }

        // Powers Goku up using the Power Button
        [HttpPost]
        [Route("/click")]
        public IActionResult Click()
        {
            goku.PowerUp();
            return Json(
                new {
                    power = goku.Power,
                    imageurl = image //fix it in post : )
                }
            );
        }
        [HttpPost]
        [Route("/add/krillin")]
        public IActionResult Krillin(data){
            
        }
    }
}
