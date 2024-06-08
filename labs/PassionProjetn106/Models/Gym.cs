using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassionProjetn106.Models
{
    public class Gym
    {
        [Key] 
        public int GymId { get; set; }

        public string GymName { get; set; }

        public string GymAddress { get; set;}

        // a gym can have many pices of equipment

        public ICollection<ExerciseEquipment> ExerciseEquipments { get; set; }
    }
}