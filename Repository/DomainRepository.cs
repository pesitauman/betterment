using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
//using Repository;

namespace Repository
{
   
    public class DomainRepository:Repository<Domain>
    {
        #region fields

        public readonly DomainUsersRepository domainUserRepository = new DomainUsersRepository();

        #endregion

        public virtual IList<Domain> GetDomainsByUserId(string UserId)
        {
            var myDomains = domainUserRepository.Table.ToList().Where(x => x.UserID == UserId).Select(x => x.Domain).ToList();
            return myDomains.ToList();
        }
    }
}