using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace PassionProjetn106.Models
{
    public class ExerciseEquipment
    {//what are some things that define the excercise equipment?
        [Key]
        public int EquipmentId {  get; set; }
        public int EquipmentWeight { get; set; }
        public string EquipmentName { get; set; }

        public decimal EquipmentPrice { get; set; }

        //A pices of equipment has one Category
        [ForeignKey("Category")]

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        // A category can include many pices of equipment
   
        // A pices of Equipment can be at many gym 

        public ICollection<Gym> Gyms { get; set; }

    }

    //Data Trasfer Object (DTO) allows us to package the information for each model
    public class ExerciseEquipmentDto
    {
        public int EquipmentId { get; set; }

        public string EquipmentName { get; set; }

        public decimal EquipmentPrice { get; set; }

        public string CategoryName { get; set; }
    }

}