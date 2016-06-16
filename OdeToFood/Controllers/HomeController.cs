﻿using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           var model = new AboutModel();
            ViewBag.Message = "Your application description page.";
           model.Name = "Scott";
           model.Location = "Merryland, USA";
           return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";


            return View();
        }
    }
}