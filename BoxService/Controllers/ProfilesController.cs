using BoxService.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoxService.Controllers
{
    public class ProfilesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        // GET: Profiles
        public ActionResult Index()
        {
            return View();
        }

        // GET: Profiles/Details/5
        public ActionResult ViewProfileDetails(string id)
        {
            var user = db.Users.Find(id);
            var s = UserManager.GetRoles(user.Id);
            if (s[0].ToString() == "Admin")
            {
                return RedirectToAction("ViewStats", "Admins");
            }
            else
            {
                return View(user);
            }
        }
        //public ActionResult ViewStats()
        //{

        //}

        // GET: Profiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profiles/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profiles/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Profiles/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profiles/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profiles/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
