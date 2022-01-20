
using CommunityProApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityProApp.Entities
{
    public class MedicalRecord : BaseEntity
    {
        public string MedicalReference { get; set; }
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }
        public string Complain { get; set; }
        public Guid? DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public string DoctorReport { get; set; }
        public string AdminReport { get; set; }
        public MedicalRecordStatus Status { get; set; }
        public DateTime DateCompleted { get; set; }
    }
}
