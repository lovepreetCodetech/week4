﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace week4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			ViewBag.countries = new List<string>()
			{
				"Usa",
				"Canada",
				"UK",
				"India"
   
			};
            return View();
        }
    }
}