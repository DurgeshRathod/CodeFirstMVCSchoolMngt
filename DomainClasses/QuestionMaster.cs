using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class QuestionMaster
    {
        [Key]
        public int QuestionId { get; set; }
        public string Questions { get; set; }
        public int PaperId { get; set; }
    }
}
