using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class FacultyMaster
    {
        [Key]
        public int FacultyId { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }
        public DateTime JoiningDate { get; set; }
        public Int64 MobileNo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
