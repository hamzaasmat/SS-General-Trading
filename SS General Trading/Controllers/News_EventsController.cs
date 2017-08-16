using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SS_General_Trading.Models;

namespace SS_General_Trading.Controllers
{
    public class News_EventsController : Controller
    {
        private Entities db = new Entities();

        // GET: News_Events
        public ActionResult Index()
        {
            return View(db.News_Events.ToList());
        }

        // GET: News
        public ActionResult News()
        {
            return View();
        }

        // GET: News_Events/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News_Events news_Events = db.News_Events.Find(id);
            if (news_Events == null)
            {
                return HttpNotFound();
            }
            return View(news_Events);
        }

        // GET: News_Events/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: News_Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address")] News_Events news_Events)
        {
            if (ModelState.IsValid)
            {
                db.News_Events.Add(news_Events);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(news_Events);
        }

        // GET: News_Events/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News_Events news_Events = db.News_Events.Find(id);
            if (news_Events == null)
            {
                return HttpNotFound();
            }
            return View(news_Events);
        }

        // POST: News_Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address")] News_Events news_Events)
        {
            if (ModelState.IsValid)
            {
                db.Entry(news_Events).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(news_Events);
        }

        // GET: News_Events/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News_Events news_Events = db.News_Events.Find(id);
            if (news_Events == null)
            {
                return HttpNotFound();
            }
            return View(news_Events);
        }

        // POST: News_Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            News_Events news_Events = db.News_Events.Find(id);
            db.News_Events.Remove(news_Events);
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
