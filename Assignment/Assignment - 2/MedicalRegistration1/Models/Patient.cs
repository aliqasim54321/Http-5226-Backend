using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalRegistration1.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        
        public string PatientFirstName { get; set;}

        public string PatientLastName { get; set;}


        // A patient belongs to one bloodGroup 
        // A bloodgroup can be there with many patient
        [ForeignKey("BloodGroup")]

        public int BloodGroupID { get; set; }
        public virtual BloodGroup BloodGroup { get; set; }

        // A patients can have appoinment with many doctors

        public ICollection<Doctor> Doctors { get; set; }
    }
    public class PatientDto
    {
        public int PatientId { get; set; }

        public string PatientFirstName { get; set; }

        public string PatientLastName { get; set; }

        public string BloodGroupName { get; set; }
    }

}