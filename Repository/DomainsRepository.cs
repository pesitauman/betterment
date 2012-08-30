using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
//using Repository;

namespace Repository
{
   
    public class DomainsRepository:Repository<Domains>
    {
        #region fields

        public readonly DomainUsersRepository domainUserRepository = new DomainUsersRepository();

        #endregion

        public virtual IList<Domains> GetDomainsByUserId(string UserId)
        {
           var x = new List<DomainUsers>();
           var myDomains=from domain in this.Table
                         join domainUser in x
                         on domain.DomainID equals domainUser.Domain.DomainID
                         where domainUser.UserID==UserId
                         orderby domain.DomainName
                         select domain;
           return myDomains.ToList();
        }
    }
}
