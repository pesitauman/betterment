using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
     [Table("T_DOMAIN_USERS")]
   public class DomainUsers:BaseEntity
    {
         [Key]
         public int Id { get; set; }
       public string UserID { get; set; }
       public Domains DomainID { get; set; }
       public bool Active { get; set; }
       public string UN { get; set; }
       public string PASS { get; set; }
    }
}
