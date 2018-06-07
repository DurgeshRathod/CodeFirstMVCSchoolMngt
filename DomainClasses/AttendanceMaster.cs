using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class AttendanceMaster
    {
        [Key]
        public int AttendanceId { get; set; }
        public DateTime? LectureDate { get; set; }
        public string attendance { get; set; }
        public string topic { get; set; }
    }
}
