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
        public DbSet<Domain> Domains { get; set; }
        public DbSet<DomainUser> DomainUsers { get; set; }
        public DbSet<DomainProp> DomainProps { get; set; }
        public DbSet<DomainPropDft> DomainPropDfts { get; set; }
        public DbSet<DomainUserProp> DomainUserProps { get; set; }
        public DbSet<UserProp> UserProps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Ignore<DomainUserProp>();
        }
 

    }
}
