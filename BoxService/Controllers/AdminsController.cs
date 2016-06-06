using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BoxService.Models;

namespace BoxService.Controllers
{
    public class AdminsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult ViewStats()
        {
            Admin admin = new Admin();
            admin.MonthlyTotal = (from User in db.Users select User.BoxPrice).Sum();
            admin.NumberOfAccounts = (db.Users.Count()) -1;
            admin.PercentTerribleBeers = Math.Round((Convert.ToDouble((from user in db.Users where user.BoxName.Equals("Box of Terrible Beers") select user).Count()) / Convert.ToDouble(admin.NumberOfAccounts)) * 100);
            admin.PercentWonderfulBeers = Math.Round((Convert.ToDouble((from user in db.Users where user.BoxName.Equals("Box of Wonderful Beers") select user).Count()) / Convert.ToDouble(admin.NumberOfAccounts)) * 100);
            admin.PercentTerribleWines = Math.Round((Convert.ToDouble((from user in db.Users where user.BoxName.Equals("Box of Terrible Wines") select user).Count()) / Convert.ToDouble(admin.NumberOfAccounts)) * 100);
            admin.PercentWonderfulWines = Math.Round((Convert.ToDouble((from user in db.Users where user.BoxName.Equals("Box of Wonderful Wines") select user).Count()) / Convert.ToDouble(admin.NumberOfAccounts)) * 100);
            return View(admin);
        }

        // GET: Admins
        public ActionResult Index()
        {
            return View(db.Admins.ToList());
        }

        // GET: Admins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = db.Admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // GET: Admins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NumberOfAccounts,MonthlyTotal,PercentTerribleBeers,PercentWonderfulBeers,PercentTerribleWines,PercentWonderfulWines")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                db.Admins.Add(admin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(admin);
        }

        // GET: Admins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = db.Admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NumberOfAccounts,MonthlyTotal,PercentTerribleBeers,PercentWonderfulBeers,PercentTerribleWines,PercentWonderfulWines")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admin);
        }

        // GET: Admins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = db.Admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Admin admin = db.Admins.Find(id);
            db.Admins.Remove(admin);
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
