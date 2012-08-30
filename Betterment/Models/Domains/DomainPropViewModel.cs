using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;

namespace Betterment.Models
{
    public class DomainPropViewModel
    {
        public int Id { get; set; }
        public Entities.Domain DomainID { get; set; }
        public string PropName { get; set; }
        public string PropDesc { get; set; }
        public string PropVal { get; set; }
        public bool PropUser { get; set; }
        public bool PropActive { get; set; }  	
    }
}