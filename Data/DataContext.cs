using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entities;

namespace Data
{
   public class DataContext : DbContext
    {
        public DataContext()
            : base("name=ApplicationServices")  
        {
           
        }
        public DbSet<Domains> Domains { get; set; }
        public DbSet<DomainUsers> DomainUsers { get; set; }
        public DbSet<DomainProp> DomainProp { get; set; }
        public DbSet<DomainPropDft> DomainPropDfts { get; set; }
        public DbSet<DomainUserProp> DomainUserProps { get; set; }
    }
}
