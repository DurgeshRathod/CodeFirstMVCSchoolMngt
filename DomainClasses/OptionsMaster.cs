using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class OptionsMaster
    {
        [Key]
        public int OptionnId { get; set; }
        public QuestionMaster QuestionId { get; set; }
        public string Option { get; set; }
    }
}
