using System;
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

            var Dstrct = db.Districts.ToList();
            ViewBag.District = Dstrct;


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var bloodGroup = db.BloodGroups.ToList();
            ViewBag.bldgrup = bloodGroup;

            var Dstrct = db.Districts.ToList();
            ViewBag.District = Dstrct;

            return View();
        }
    }
}