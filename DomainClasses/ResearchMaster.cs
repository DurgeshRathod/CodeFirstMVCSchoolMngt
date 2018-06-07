using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class ResearchMaster
    {
        [Key]
        public int ResearchId { get; set; }
        public int FacultyId { get; set; }
        public string Research { get; set; }

    }
}
