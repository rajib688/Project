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

            var Viewpost = db.Requests.OrderByDescending(r=>r.Id).Take(6);
            ViewBag.pst = Viewpost;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(string bloodGroup, string bloodGroup1)
        {
            //var bloodGroup = db.BloodGroups.ToList();
            //ViewBag.bldgrup = bloodGroup;

            //var Dstrct = db.Districts.ToList();
            //ViewBag.District = Dstrct;

            var search = db.Districts.Where(m => m.DistrictName.Contains(bloodGroup) || bloodGroup == null).ToList();

            return View(search);
        }
    }
}