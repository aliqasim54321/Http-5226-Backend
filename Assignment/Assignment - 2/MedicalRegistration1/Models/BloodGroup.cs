using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace MedicalRegistration1.Models
{
    public class BloodGroup
    {
        public int BloodGroupId { get; set; }

        public string BloodGroupName { get; set; }
    }
}