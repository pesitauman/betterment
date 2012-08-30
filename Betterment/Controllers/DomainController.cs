using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository;
using Betterment.Models.Domain;
using Betterment.Models;
using Betterment.Extensions;
using System.Security.Principal;
using System.Web.Security;

namespace Betterment.Controllers
{
   
    public class DomainController : Controller
    {
        #region fields

        public readonly DomainRepository domainsRepository = new DomainRepository();

        #endregion

        public ActionResult NavigationForm()
        {
            var userId = Membership.GetUser().ProviderUserKey.ToString();
            var model=new NavigationViewModel();
            //  model.MyDomains = domainsRepository.All().ToModel(); 900aa404-d202-4cac-8045-a5c19a23bc1b
            model.MyDomains = domainsRepository.GetDomainsByUserId(userId).ToModel();
            return View(model);
        }

    }
}
