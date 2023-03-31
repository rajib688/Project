﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BloodBank.Models;

namespace BloodBank.Controllers
{
    public class HomeController : Controller
    {
        Blood_BankFEntities db = new Blood_BankFEntities();
        public ActionResult Index()
        {
            var bloodGroup = db.BloodGroups.ToList();
            ViewBag.bldgrup = bloodGroup;




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
    }
}