using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mori.Models;

namespace Mori.Controllers.Admin
{
    public class SlidersController : Controller
    {
        private MyModel db = new MyModel();

        // GET: Sliders
        public ActionResult Index()
        {
            return View(db.MainSliders.ToList());
        }

        // GET: Sliders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainSlider mainSlider = db.MainSliders.Find(id);
            if (mainSlider == null)
            {
                return HttpNotFound();
            }
            return View(mainSlider);
        }

        // GET: Sliders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sliders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,Url,ImageName,SliderType,SliderStatus")] MainSlider mainSlider)
        {
            if (ModelState.IsValid)
            {
                db.MainSliders.Add(mainSlider);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mainSlider);
        }

        // GET: Sliders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainSlider mainSlider = db.MainSliders.Find(id);
            if (mainSlider == null)
            {
                return HttpNotFound();
            }
            return View(mainSlider);
        }

        // POST: Sliders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,Url,ImageName,SliderType,SliderStatus")] MainSlider mainSlider)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mainSlider).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mainSlider);
        }

        // GET: Sliders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainSlider mainSlider = db.MainSliders.Find(id);
            if (mainSlider == null)
            {
                return HttpNotFound();
            }
            return View(mainSlider);
        }

        // POST: Sliders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MainSlider mainSlider = db.MainSliders.Find(id);
            db.MainSliders.Remove(mainSlider);
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
