using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository;

namespace Betterment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            var DomainsRepository = new DomainsRepository();
            var allD = DomainsRepository.Table.ToList();

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
