using MedicalRegistration1.Migrations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MedicalRegistration1.Controllers
{
    public class PatientController : Controller
    {
        
        private static readonly HttpClient client;
        private JavaScriptSerializer jss = new JavaScriptSerializer();

        static PatientController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44391/api/PatientsData/");
        }
        // GET: Patient/List
        public ActionResult List()
        {
            //objective : communicate with our patient data api to retrieve a  list of patient
            //curl https://localhost:44391/api/PatientsData/ListPatients

          
            string url = "ListPatients";
            HttpResponseMessage response = client.GetAsync(url).Result;

            Debug.WriteLine("The response code is");
            Debug.WriteLine(response.StatusCode);

            IEnumerable<MedicalRegistration1.Models.PatientDto> patients = response.Content.ReadAsAsync<IEnumerable<MedicalRegistration1.Models.PatientDto>>().Result;
            Debug.WriteLine("Number of patient present");
            Debug.WriteLine(patients.Count());
          
            return View(patients);
        }

        // GET: Patient/Details/5
        public ActionResult Details(int id)
        {

            //objective : communicate with our patient data api to retrieve one of patient
            //curl https://localhost:44391/api/PatientsData/findPatient/{id}

        
            string url = "findPatient/"+id;
            HttpResponseMessage response = client.GetAsync(url).Result;

           // Debug.WriteLine("The response code is");
           // Debug.WriteLine(response.StatusCode);

            MedicalRegistration1.Models.PatientDto selectedpatient = response.Content.ReadAsAsync<MedicalRegistration1.Models.PatientDto>().Result;
          //  Debug.WriteLine("Number of patient present: ");
           // Debug.WriteLine(selectedpatient.PatientFirstName);

            return View(selectedpatient);
        }

        //GET: Patient/New

        public ActionResult New()
        {
            return View();
        }




        // POST: Patient/Create
        [HttpPost]
        public ActionResult Create(Patient patient)
        {
            Debug.WriteLine("The jsonpayloade is:");
            //Debug.WriteLine(patient.patient);

            //Add new patient into our database using API
            //curl -H "Content-Type:application/json" -d @patient.json https://localhost:44391/api/PatientsData/addpatient

            string url = "addpatient";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonpayload =  jss.Serialize(patient);

            Debug.WriteLine(jsonpayload);

            HttpContent content = new StringContent(jsonpayload);
            content.Headers.ContentType.MediaType = "application/json";

            client.PostAsync(url, content);

            return RedirectToAction("List");
        }

        // GET: Patient/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Patient/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Patient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Patient/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
