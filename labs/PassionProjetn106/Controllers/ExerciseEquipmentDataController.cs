using PassionProjetn106.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PassionProjetn106.Controllers
{
    public class ExerciseEquipmentDataController : ApiController
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        /// <summary>
        ///List the excersice Equipment in the database
        /// </summary>
        /// <returns>An array of excersice Equipment objects dtos</returns>
        /// <example>
        ///   //GET : api/ExerciseEquipmentData/ListExerciseEquipment->[{"EquipmentId":1,"EquipmentName":"Dumbells"},{"EquipmentId":2,"EquipmentName":"treadmill}]
        ///   </example>

        [HttpGet]
        [Route("api/ExerciseEquipmentData/FindExerciseEquipment/{id}")]

        public ExerciseEquipmentDto FindExerciseEquipment(int id)
        {
            //SELECT * FROM EXERECISEEQUIPMENTS
            ExerciseEquipment Equipment = db.ExerciseEquipments.Find(id);

            ExerciseEquipmentDto Dto = new ExerciseEquipmentDto();

            Dto.EquipmentName = Equipment.EquipmentName;
            Dto.EquipmentPrice = Equipment.EquipmentPrice;
            Dto.EquipmentId = Equipment.EquipmentId;
            Dto.CategoryName = Equipment.Category.CategoryName;

            return Dto;

        }
    }
}