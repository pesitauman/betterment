using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository;
using Betterment.Models.Domain;
using Betterment.Models;
using Betterment.Extensions;

namespace Betterment.Controllers
{
   
    public class DomainController : Controller
    {
        #region fields

        public readonly DomainRepository domainsRepository = new DomainRepository();

        #endregion

        public ActionResult NavigationForm()
        {
           // var user = httpContext.User;
            var model=new NavigationViewModel();
          //  model.MyDomains = domainsRepository.All().ToModel();
            model.MyDomains = domainsRepository.GetDomainsByUserId("").ToModel();
            return View(model);
        }

    }
}
