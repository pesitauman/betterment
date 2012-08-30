using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    [Table("T_DOMAINS")]
   public class Domain:BaseEntity 
    {
        [Key]
        [MaxLength(10)]
        public string DomainID { get; set; }
        [MaxLength(30)]
        public string DomainName { get; set; }
        public byte[] Icon { get; set; }
        public string color { get; set; }        

    }
}
