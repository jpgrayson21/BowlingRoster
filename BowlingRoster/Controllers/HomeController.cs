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

        public IActionResult Index(int id = 0)
        {
            var bowlerList = new List<Bowler>();
            
            // All bowlers
            if (id == 0)
            {
                bowlerList = _repo.Bowlers
                .ToList();

                ViewBag.Selected = "All Bowlers";
            }

            // Filtered bowlers
            else
            {
                bowlerList = _repo.Bowlers
                .Where(x => x.TeamID == id)
                .ToList();

                Team team = _repo.Teams
                    .FirstOrDefault(x => x.TeamID == id);
                ViewBag.Selected = team.TeamName;
            }

            return View(bowlerList);
        }

        // Add Bowler view routes
        [HttpGet]
        public IActionResult AddBowler()
        {
            var newBowler = new Bowler();
            ViewBag.Teams = _repo.Teams.ToList();
            return View("BowlerForm", newBowler);
        }

        [HttpPost]
        public IActionResult AddBowler(Bowler bowler)
        {
            if (ModelState.IsValid)
            {
                _repo.AddBowler(bowler);
                return RedirectToAction("Confirmation", bowler);
            }
            else
            {
                var newBowler = new Bowler();
                ViewBag.Teams = _repo.Teams.ToList();
                return View("BowlerForm", newBowler);
            }
        }

        // Edit Bowler view routes
        [HttpGet]
        public IActionResult EditBowler(int id)
        {
            var bowler = _repo.Bowlers.FirstOrDefault(x => x.BowlerID == id);
            ViewBag.Teams = _repo.Teams.ToList();
            return View("BowlerForm", bowler);
        }

        [HttpPost]
        public IActionResult EditBowler(Bowler bowler)
        {
            if (ModelState.IsValid)
            {
                _repo.SaveBowler(bowler);
                return RedirectToAction("Confirmation", bowler);
            }
            else
            {
                return View("BowlerForm", bowler);
            }
        }

        // Delete Bowler view routes
        [HttpGet]
        public IActionResult DeleteBowler(int id)
        {
            var bowler = _repo.Bowlers.FirstOrDefault(x => x.BowlerID == id);
            return View(bowler);
        }

        [HttpPost]
        public IActionResult DeleteBowler(Bowler bowler)
        {
            _repo.DeleteBowler(bowler);
            return RedirectToAction("Index");
        }
        
        // Confirmation view route
        public IActionResult Confirmation(Bowler bowler)
        {
            return View(bowler);
        }
    }
}
