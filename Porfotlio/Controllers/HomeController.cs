﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;

namespace Porfotlio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult AboutPage() 
        {
            return View();
        }
        public ActionResult ProfileEnter() 
        {
            return View();
        }
        public ActionResult ProfileShow()
        { 
            return View();
        }
    }
}