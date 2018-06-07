using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class BatchMaster
    {
        [Key]
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public int Batch_totalStud { get; set; }
        public DateTime? BatchStart { get; set; }
        public DateTime? BatchEnd { get; set; }
        public string BatchDuration { get; set; }
        public string BatchProgress { get; set; }
        public string BatchDays { get; set; }
        public string BatchStatus { get; set; }
    }
}
