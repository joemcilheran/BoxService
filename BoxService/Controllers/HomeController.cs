﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoxService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Boxes and Boxes: Boxes for Lovers and Haters";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please Don't Contact Us";

            return View();
        }
    }
}