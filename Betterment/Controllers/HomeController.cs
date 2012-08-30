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
            //ViewBag.Message = "Welcome to ASP.NET MVC!";
            //var domainsRepository = new DomainsRepository();
            //var domainUserPropRepository = new DomainUserPropRepository();
            //var allD = domainsRepository.Table.ToList();
            //var domain = new Domains() { DomainName = "hgfhgf" };
            //domainsRepository.Add(domain);
            //var domainUserProp = new DomainUserProp() {  PropName = "bbb" };
            //domainUserPropRepository.Add(domainUserProp);
           // return View();
            return RedirectToAction("LogOn", "Account");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
