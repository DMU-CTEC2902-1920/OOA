using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GamesReviewWebsite.Models;



namespace GamesReviewWebsite.Controllers
{

    
    public class GamesCollectionsController : Controller
    {
        private GamesCollection game;
        public GamesCollectionsController() { }
        public GamesCollectionsController(GamesCollection model)
        {
            game = model;
        }
        private GamesCollectionContext db = new GamesCollectionContext();

        // GET: GamesCollections
        public ActionResult Index()
        {
            return View(db.GamesCollections.ToList());
        }

        // GET: GamesCollections/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GamesCollection gamesCollection = db.GamesCollections.Find(id);
            if (gamesCollection == null)
            {
                return HttpNotFound();
            }
            return View(gamesCollection);
        }

        // GET: GamesCollections/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GamesCollections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GameID,GameDeveloper,GameGenre,GameScore,GameAgeRating,GameName,GameDescription,Games")] GamesCollection gamesCollection)
        {
            if (ModelState.IsValid)
            {
                db.GamesCollections.Add(gamesCollection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gamesCollection);
        }

        // GET: GamesCollections/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GamesCollection gamesCollection = db.GamesCollections.Find(id);
            if (gamesCollection == null)
            {
                return HttpNotFound();
            }
            return View(gamesCollection);
        }

        // POST: GamesCollections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GameID,GameDeveloper,GameGenre,GameScore,GameAgeRating,GameName,GameDescription,Games")] GamesCollection gamesCollection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gamesCollection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gamesCollection);
        }

        // GET: GamesCollections/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GamesCollection gamesCollection = db.GamesCollections.Find(id);
            if (gamesCollection == null)
            {
                return HttpNotFound();
            }
            return View(gamesCollection);
        }

        // POST: GamesCollections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GamesCollection gamesCollection = db.GamesCollections.Find(id);
            db.GamesCollections.Remove(gamesCollection);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public string Games(int Id, int GameID)
        {
            return String.Format("Id = {0}, Game ID = {1}", Id, GameID);
        }

        public ViewResult Games()
        {
            if (game == null)
            {
                game = new GamesCollection();
                game.GameName = "Call Of Duty";
                game.GameDescription = "War shooter that focuses on killing the enemy side";
                game.GameAgeRating = 18;
            }
            if (game.GameAgeRating > 18)
            {
                ViewBag.SubTitle = "This game is suitable for those under 18 to play ";
            }
            else
            {
                ViewBag.SubTitle = "Only those aged 18 and over may play this game ";
            }
            return View(game);
        }
    }
}
