using System;

namespace TestAssignment.Models
{
    public sealed class DataModel
    {
        public int MachineNumber { get; set; }
        public decimal GrossWeight { get; set; }
        public decimal TareWeight { get; set; }
        public decimal NetWeight { get; set; }
        public DateTime TareDate { get; set; }
        public DateTime GrossDate { get; set; }
    }
}
