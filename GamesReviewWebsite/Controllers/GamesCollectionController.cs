using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GamesReviewWebsite.Models;

namespace GamesReviewWebsite.Controllers
{
    public class GamesCollectionController : Controller
    {
        private List<GamesCollection> _gamesCollection = new List<GamesCollection>()
        {
            new GamesCollection { GameID = 1,
            GameName = "League Of Legends",
            GameDescription = "This is currently the largest moba available to play",
            GameAgeRating = 12,
            GameGenre = "MOBA",
            GameScore = 7,
            GameDeveloper = "Riot Games" },
            new GamesCollection { GameID = 2,
            GameName = "Counter Strike Global Offensive",
            GameDescription = "Sneaky Breaky like.",
            GameAgeRating = 18,
            GameGenre = "FPS (First Person Shooter)",
            GameScore = 8,
            GameDeveloper = "Valve" },
            new GamesCollection {GameID = 3,
            GameName = "Smite",
            GameDescription = "Not as big as League of Legends but just as good.",
            GameAgeRating = 12,
            GameGenre = "FPS Moba",
            GameScore = 9,
            GameDeveloper = "Hi-Rez Studios"},
            };
        // GET: Details/id
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
            GamesCollection selectedGames = _gamesCollection.First(g => g.GameID == id);

            if (selectedGames == null) return new HttpNotFoundResult();
            return View(selectedGames);
        }

        //GET: Games
        public ActionResult Index()
        {
            return View(_gamesCollection);
        }
    };
}



        
