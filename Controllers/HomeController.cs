using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dragonBallClick.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            Player goku = new Player();
            return View();
        }
        [HttpPost]
        [Route("/click")]
        public IActionResult Click()
        {
            goku.PowerUp();
        }
    }
}
