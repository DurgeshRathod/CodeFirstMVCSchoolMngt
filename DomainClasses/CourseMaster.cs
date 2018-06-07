using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class CourseMaster
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string BatchName { get; set; }
        public string StudentStatus { get; set; }
        public string LectureStatus { get; set; }
        public string FacultyName { get; set; }
        public UserMaster UserCode { get; set; }
        public BatchMaster BatchId { get; set; }

    }
}
