﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MedicalRegistration1.Models;
using System.Diagnostics;

namespace MedicalRegistration1.Controllers
{
    public class PatientsDataController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/PatientsData/ListPatients
        [HttpGet]
        public IEnumerable<PatientDto> ListPatients()
        {
            List<Patient> Patients = db.Patients.ToList();
            List<PatientDto> PatientDtos = new List<PatientDto>();

            Patients.ForEach(p => PatientDtos.Add(new PatientDto()
            {
                PatientId = p.PatientId,
                PatientFirstName = p.PatientFirstName,
                PatientLastName = p.PatientLastName,
                BloodGroupName = p.BloodGroup.BloodGroupName
               
            }));
            return PatientDtos;
        }

        // GET: api/PatientsData/FindPatient/5
        [ResponseType(typeof(Patient))]
        [HttpGet]
        public IHttpActionResult FindPatient(int id)

        {
            Patient Patient = db.Patients.Find(id);
            PatientDto PatientDto = new PatientDto()
            {
                PatientId = Patient.PatientId,
                PatientFirstName = Patient.PatientFirstName,
                PatientLastName = Patient.PatientLastName,
                BloodGroupName = Patient.BloodGroup.BloodGroupName
            };
        
            if (Patient == null)
            {
                return NotFound();
            }

            return Ok(PatientDto);
        }

        // POST: api/PatientsData/UpdatePatient/5
        [ResponseType(typeof(void))]

        [HttpPost]
        public IHttpActionResult UpdatePatient(int id, Patient patient)
        {
            Debug.WriteLine("i have reached the update patient method");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != patient.PatientId)
            {
                return BadRequest();
            }

            db.Entry(patient).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PatientsData/AddAnimal
        [ResponseType(typeof(Patient))]
        [HttpPost]
        public IHttpActionResult AddPatient(Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Patients.Add(patient);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = patient.PatientId }, patient);
        }

        // POST: api/PatientsData/DeletePatient/5
        [ResponseType(typeof(Patient))]
        [HttpPost]
        public IHttpActionResult DeletePatient(int id)
        {
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return NotFound();
            }

            db.Patients.Remove(patient);
            db.SaveChanges();

            return Ok(  );
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PatientExists(int id)
        {
            return db.Patients.Count(e => e.PatientId == id) > 0;
        }
    }
}