﻿using System.Web.Mvc;

namespace CiCdExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Hello World";

            return View();
        }
    }
}
