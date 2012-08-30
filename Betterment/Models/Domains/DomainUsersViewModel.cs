using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;

namespace Betterment.Models
{
    public class DomainUsersViewModel
    {
        public int Id { get; set; }
        public string UserID { get; set; }
        public Entities.Domain DomainID { get; set; }
        public bool Active { get; set; }
        public string UN { get; set; }
        public string PASS { get; set; }
    }
}