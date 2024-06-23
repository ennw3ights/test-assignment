using System;
using System.ComponentModel.DataAnnotations;

namespace TestAssignment.Models
{
    public sealed class DataModel
    {
        [Key]
        public int MachineId { get; set; }
        public decimal GrossWeight { get; set; }
        public decimal TareWeight { get; set; }
        public decimal NetWeight { get; set; }
        public DateTime TareDate { get; set; }
        public DateTime GrossDate { get; set; }
    }
}
