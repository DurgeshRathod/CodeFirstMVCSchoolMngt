using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class OnlineExamMaster
    {
        [Key]
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public int PaperId { get; set; }
        public DateTime? ExamDate { get; set; }
    }
}
