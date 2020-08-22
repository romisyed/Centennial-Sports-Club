using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syed_Rumail.Models;

namespace Syed_Rumail.Controllers
{
    public class ClubsController : Controller
    {
        private IClubRepository repository;

        public ClubsController(IClubRepository repo)
        {
            repository = repo;

        }

        public ViewResult AddClubPage()
        {

            return View("AddClubPage");
        }
        public ViewResult ClubDetailsPage()
        {
            return View(repository.Club.OrderBy(p => p.Id));
        }

        public ViewResult ClubPage()
        {
            return View(repository.Club.OrderBy(p => p.Id));
        }
        [HttpPost]
        public IActionResult AddClubPage(Clubs clubResponse)
        {
            if (ModelState.IsValid)
            {
                repository.SaveClub(clubResponse);
                return RedirectToAction("ClubDetailsPage");
            }
            else
            {
                return RedirectToAction("Clubs");
            }
        }

        public RedirectToActionResult DeleteClub(int id)
        {
            Clubs deleteClub = repository.DeleteClub(id);
            return RedirectToAction("ClubDetailsPage");
        }
        public ViewResult UpdateClubPage(int id) =>
            View(repository.Club.FirstOrDefault(p => p.Id == id));


        [HttpPost]
        public IActionResult UpdateClubPage(Clubs clubResponse)
        {
            repository.SaveClub(clubResponse);
            return RedirectToAction("ClubDetailsPage");
        }

    }
}