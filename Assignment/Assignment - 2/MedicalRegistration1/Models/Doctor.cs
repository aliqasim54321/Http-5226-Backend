using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalRegistration1.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        public string DoctorName { get; set;}

        public string Specialization { get; set; }

        // A Doctor can have many Patient
        
        public ICollection<Patient> Patients { get; set; }
    }

}