using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class ResultMaster
    {
        [Key]
        public int ResultId { get; set; }
        public string Category { get; set; }
        public DateTime? ExamDate { get; set; }
        public int Obt_marks { get; set; }
        public int Total_marks { get; set; }
        public string Attendance { get; set; }
        public string Course { get; set; }
        public string Batch { get; set; }
    }
}
