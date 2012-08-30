using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    [Table("T_USER_PROP")]
    public class UserProp : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        [MaxLength(10)]
        public string PropName { get; set; }
        [MaxLength(10)]
        public string PropDesc { get; set; }
        public string PropVal { get; set; }
        public bool PropActive { get; set; }
    }
}