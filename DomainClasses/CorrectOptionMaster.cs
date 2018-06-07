using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class CorrectOptionMaster
    {
        [Key]
        public int CorrectOptionId { get; set; }
        public int QuestionId { get; set; }
        public int OptionId { get; set; }
    }
}
