using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class SuggestionMaster
    {
        [Key]
        public int SuggestionId { get; set; }
        public string Suggestion { get; set; }
        public DateTime Date { get; set; }
    }
}
