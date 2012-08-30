using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository;
using Entities;

namespace Betterment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("LogOn", "Account");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
