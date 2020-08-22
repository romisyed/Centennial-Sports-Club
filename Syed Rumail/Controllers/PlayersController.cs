using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syed_Rumail.Models;

namespace Syed_Rumail.Controllers
{
    public class PlayersController : Controller
    {
        private IPlayerRepository repository;
        private IClubRepository clubRepository;

        public PlayersController(IPlayerRepository repo, IClubRepository clubrepo)
        {
            repository = repo;
            clubRepository = clubrepo;
        }

        public ViewResult ManagePlayersPage()
        {
            ViewBag.Clubs = clubRepository.Club;
            return View("ManagePlayersPage");
        }

        public ViewResult ClubDetailsPage()
        {
            return View(repository.Player.OrderBy(p => p.PlayerId));
        }


        [HttpPost]
        public IActionResult ManagePlayersPage(Players playerResponses)
        {
            if (ModelState.IsValid)
            {
                repository.SavePlayer(playerResponses);

                return RedirectToAction("ClubDetailsPage", "Clubs");
            }
            else
            {
                return RedirectToAction("ClubPage", "Clubs");
            }
        }


    }
}