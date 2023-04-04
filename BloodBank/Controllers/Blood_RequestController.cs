using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BloodBank.Models;

namespace BloodBank.Controllers
{
    [Authorize]
    public class Blood_RequestController : Controller
    {
        Blood_BankFEntities db = new Blood_BankFEntities();
        // GET: Blood_Request
        public ActionResult Index()
        {
            var bloodGroup = db.BloodGroups.ToList();
            ViewBag.bldgrup = bloodGroup;



            return View();
        }
    }
}