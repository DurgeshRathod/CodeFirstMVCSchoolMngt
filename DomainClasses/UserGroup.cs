using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class UserGroup
    {
        [Key]
        public int UserGroupid { get; set; }
        public string GroupName { get; set; }
    }
}
