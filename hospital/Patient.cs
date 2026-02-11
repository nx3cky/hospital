using System;
using System.Collections.Generic;
using System.Text;

namespace hospital
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Admission { get; set; }
        public DateTime? Discharge { get; set; }
        public Diagnosis Diagnosis { get; set; }
        public string Treatment { get; set; }
        public InsurancePolicyType InsurancePolicy { get; set; } 
        public int WardId { get; set; }
        public decimal TreatmentCost { get; set; }
    }
}
