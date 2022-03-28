using BowlingRoster.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingRoster.Controllers
{
    public class HomeController : Controller
    {
        private IBowlersRepository _repo { get; set; } 

        //constructor
        public HomeController(IBowlersRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var bowlerList = _repo.Bowlers
                .ToList();

            return View(bowlerList);
        }
    }
}
