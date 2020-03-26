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
    public class GamesListController : Controller
    {
        private GamesListContext db = new GamesListContext();

        // GET: GamesList
        public ActionResult Index()
        {
            return View(db.GamesCollections.ToList());
        }

        // GET: GamesList/Details/5
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

        // GET: GamesList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GamesList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GameID,GameDeveloper,GameGenre,GameName,GameDescription,GameScore,GameAgeRating,Games")] GamesCollection gamesCollection)
        {
            if (ModelState.IsValid)
            {
                db.GamesCollections.Add(gamesCollection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gamesCollection);
        }

        // GET: GamesList/Edit/5
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

        // POST: GamesList/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GameID,GameDeveloper,GameGenre,GameName,GameDescription,GameScore,GameAgeRating,Games")] GamesCollection gamesCollection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gamesCollection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gamesCollection);
        }

        // GET: GamesList/Delete/5
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

        // POST: GamesList/Delete/5
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
    }
}
