using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Betterment.Models
{
    public class DomainPropDftViewModel
    {
        public int Id { get; set; }
        public string PropName { get; set; }
        public string PropDesc { get; set; }
        public string PeopVal { get; set; }
        public bool PropUser { get; set; }
        public bool PropActive { get; set; }
        public bool DefaultActive { get; set; }	
    }
}