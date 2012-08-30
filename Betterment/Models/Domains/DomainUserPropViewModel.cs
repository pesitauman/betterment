using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;

namespace Betterment.Models
{
    public class DomainUserPropViewModel
    {
        public int Id { get; set; }
        public DomainUser DomainUserID { get; set; }
        public string PropName { get; set; }
        public string PeopVal { get; set; }
        public bool PropActive { get; set; }	
    }
}