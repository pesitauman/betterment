using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
     [Table("T_DOMAIN_PROP_DFT")]
    public class DomainPropDft : BaseEntity
    {
         [Key]
        public int Id { get; set; }
         [MaxLength(10)]
       	public string  PropName { get; set; }
	     [MaxLength(10)]
       	public string PropDesc { get; set; }
       	public string PeopVal { get; set; }	
       	public bool PropUser { get; set; }	
       	public bool PropActive { get; set; }	
       	public bool DefaultActive { get; set; }	
    }
}

