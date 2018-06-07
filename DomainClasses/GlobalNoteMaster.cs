using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class GlobalNoteMaster
    {
        [Key]
        public int GlobalNoteId { get; set; }
        public string Note { get; set; }
        public DateTime? Date{ get; set; }
    }
}
