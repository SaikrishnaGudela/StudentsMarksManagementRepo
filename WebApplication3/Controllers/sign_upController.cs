using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class sign_upController : Controller
    {
        private ManageEntities db = new ManageEntities();

        // GET: sign_up
        public ActionResult Index()
        {
            return View(db.sign_up.ToList());
        }

        // GET: sign_up/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sign_up sign_up = db.sign_up.Find(id);
            if (sign_up == null)
            {
                return HttpNotFound();
            }
            return View(sign_up);
        }

        // GET: sign_up/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: sign_up/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,first_name,last_name,user_name,password")] sign_up sign_up)
        {
            if (ModelState.IsValid)
            {
                db.sign_up.Add(sign_up);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sign_up);
        }

        // GET: sign_up/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sign_up sign_up = db.sign_up.Find(id);
            if (sign_up == null)
            {
                return HttpNotFound();
            }
            return View(sign_up);
        }

        // POST: sign_up/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,first_name,last_name,user_name,password")] sign_up sign_up)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sign_up).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sign_up);
        }

        // GET: sign_up/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sign_up sign_up = db.sign_up.Find(id);
            if (sign_up == null)
            {
                return HttpNotFound();
            }
            return View(sign_up);
        }

        // POST: sign_up/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sign_up sign_up = db.sign_up.Find(id);
            db.sign_up.Remove(sign_up);
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
