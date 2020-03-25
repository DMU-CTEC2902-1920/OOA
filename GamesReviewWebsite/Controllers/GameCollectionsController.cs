using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GamesReviewWebsite.Models;

namespace GamesReviewWebsite.Controllers
{
    public class GameCollectionsController : Controller
    {
        private List<GamesCollection> _gamesCollection = new List<GamesCollection>()
        {
            new GamesCollection{ GameID = 1,
            GameName = "League Of Legends",
            GameGenre = "MOBA (Multiplayer Online Battle Arena)",
            GameDescription = "This game is the largest MOBA right now.",
            GameAgeRating = 12,
            GameDeveloper = "Riot Games",
            GameScore = 7},
            new GamesCollection{ GameID = 2,
            GameName = "Counter Strike Global Offensive",
            GameGenre = "FPS (First Person Shooter)",
            GameDescription = "This is one of the largest FPS shooters available on PC and Xbox",
            GameAgeRating = 18,
            GameDeveloper = "Valve",
            GameScore = 10},
            new GamesCollection{ GameID = 3,
            GameName = "Smite",
            GameGenre = "MOBA (Multiplayer Online Battle Arena) / FPS (First Person Shooter)",
            GameDescription = "This MOBA isn't as big as League Of Legends but its way better.",
            GameAgeRating = 12,
            GameDeveloper = "Hi-Rez Studios",
            GameScore = 8},
            new GamesCollection{ GameID = 4,
            GameName = "F1 2019",
            GameGenre = "Racing",
            GameDescription = "This is a game for Racing enthusiasts, simulating the ultimate racing sport. F1! ",
            GameAgeRating = 12,
            GameDeveloper = "CodeMasters",
            GameScore = 9},
        };

        // GET: GameCollections
        public ActionResult Index()
        {
            return View(_gamesCollection);
        }

        //GET: Details/id
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
           GamesCollection selectedGame = _gamesCollection.First(g => g.GameID == id);

            if (selectedGame == null) return new HttpNotFoundResult();


            User user = new User
            {
                UserID = 1,
                FirstName = "Steve",
                LastName = "Jobs"
            };            UserGameViewModel viewModel = new UserGameViewModel
            {
                User = user,
                GamesCollection = selectedGame
            };            return View(viewModel);
        }
        //GET: Edit/id
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
            GamesCollection selectedGame = _gamesCollection.First(g => g.GameID == id);
            if (selectedGame == null) return new HttpNotFoundResult();
            return View(selectedGame);
        }
        // POST: Edit
        [HttpPost]
        public ActionResult Edit(GamesCollection gamesCollection)
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine(gamesCollection.GameName);
                Debug.WriteLine(gamesCollection.GameDescription);
                Debug.WriteLine(gamesCollection.GameGenre);
                Debug.WriteLine(gamesCollection.GameAgeRating);
                Debug.WriteLine(gamesCollection.GameDeveloper);
                Debug.WriteLine(gamesCollection.GameScore);
                return RedirectToAction("Index");
            }
            else
            {
                return View(gamesCollection);
            }
        }
    }
}