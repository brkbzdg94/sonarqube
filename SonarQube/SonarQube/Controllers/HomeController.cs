﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SonarQube.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void sonar()
        {
            int target = -5;
            int num = 3;

            target = -num;  // Noncompliant; target = -3. Is that really what's meant?
            target = +num; // Noncompliant; target = 3
        }
    }
}