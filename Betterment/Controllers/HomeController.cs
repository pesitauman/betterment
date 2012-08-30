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
        public readonly DomainRepository domainsRepository = new DomainRepository();

        public ActionResult Index()
        {
            var MyDomains = domainsRepository.Table.ToList();
            return RedirectToAction("LogOn", "Account");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
