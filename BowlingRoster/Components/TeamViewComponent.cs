using BowlingRoster.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingRoster.Components
{
    public class TeamViewComponent : ViewComponent
    {
        private IBowlersRepository _repo { get; set; }

        public TeamViewComponent(IBowlersRepository repo)
        {
            _repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            var teams = _repo.Teams.ToList();

            return View(teams);
        }
    }
}
