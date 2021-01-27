using IubObe.Web.DB;
using IubObe.Web.Models;
using IubObe.Web.ViewModels;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IubObe.Web.Controllers
{
    public class FacultyController : Controller
    {

        List<string> FacultyList = new List<string>()
        {
           "mahady@iub.edu.bd"
        };
        private MainDataContext db = new MainDataContext();
        // GET: Faculty

        public ActionResult FacultyLogin()
        {
            return View();
        }   
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult FacultyLogin(Faculty model, string button)
        {


            if (model == null)
            {
                return HttpNotFound();
            }

            if (button == "Clear")
            {

                ModelState.Clear();
                return View();

            }
            
            var userExist = db.Faculties.Where(u => u.Email.Equals(model.Email)).FirstOrDefault();
            if (userExist == null)
                return HttpNotFound("Email does not found in the database");
            var check = userExist.Email.Equals(model.Email) && userExist.Password.Equals(model.Password);
            if (!check)
            {
                ModelState.AddModelError("error", "email and password do not match");
                return View("Login");
            }
            if (userExist != null && check)
            {


            }
            return RedirectToAction("Results");

            //var facultyExist = FacultyList.Where(u => u.Equals(model.Email)).FirstOrDefault();
            //if (facultyExist == null)
            //{
            //    ModelState.AddModelError("error", "This is not a faculty email address");
            //    return View();

               
            //}
            //return RedirectToAction("PloView");

        }
        
        public ActionResult Results()
        {
            return View();
        }
       

        public void readData()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();

            dataPoints.Add(new DataPoint("PO2", 43));
            dataPoints.Add(new DataPoint("PO3", 46));
            dataPoints.Add(new DataPoint("PO4", 31));
            dataPoints.Add(new DataPoint("PO6", 56));

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

        }
        public ActionResult PAV()
        {

            readData();
            return View();
        }
        public ActionResult SPV()
        {
            List<DataPoint> dataPoints1 = new List<DataPoint>();
            List<DataPoint> dataPoints2 = new List<DataPoint>();
            List<DataPoint> dataPoints3 = new List<DataPoint>();

            dataPoints1.Add(new DataPoint("SEMESTER1", 5));
            dataPoints1.Add(new DataPoint("SEMESTER2", 6));
            dataPoints1.Add(new DataPoint("SEMESTER3", 7));
            dataPoints1.Add(new DataPoint("SEMESTER4", 4));
            dataPoints1.Add(new DataPoint("SEMESTER5", 4));
            dataPoints1.Add(new DataPoint("SEMESTER6", 5));

            dataPoints2.Add(new DataPoint("SEMESTER1", 4));
            dataPoints2.Add(new DataPoint("SEMESTER2", 5));
            dataPoints2.Add(new DataPoint("SEMESTER3", 4));
            dataPoints2.Add(new DataPoint("SEMESTER4", 4));
            dataPoints2.Add(new DataPoint("SEMESTER5", 3));
            dataPoints2.Add(new DataPoint("SEMESTER6", 5));

            //dataPoints3.Add(new DataPoint("SEMESTER1", 38));
            //dataPoints3.Add(new DataPoint("SEMESTER2", 46));
            //dataPoints3.Add(new DataPoint("SEMESTER3", 55));
            //dataPoints3.Add(new DataPoint("SEMESTER4", 70));
            //dataPoints3.Add(new DataPoint("SEMESTER5", 77));
            //dataPoints3.Add(new DataPoint("SEMESTER6", 91));

            ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataPoints1);
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataPoints2);
            ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataPoints3);
            return View();



           
        }

        public ActionResult CPV()
        {
            List<DataPoint> dataPoints4 = new List<DataPoint>();
            List<DataPoint> dataPoints5 = new List<DataPoint>();
            List<DataPoint> dataPoints6 = new List<DataPoint>();

            dataPoints4.Add(new DataPoint("CSE101", 5));
            dataPoints4.Add(new DataPoint("CSE104", 6));
            dataPoints4.Add(new DataPoint("CSE201", 7));
            dataPoints4.Add(new DataPoint("CSE203", 4));
            dataPoints4.Add(new DataPoint("CSE204", 4));
            dataPoints4.Add(new DataPoint("CSE210", 5));

            dataPoints5.Add(new DataPoint("CSE101", 4));
            dataPoints5.Add(new DataPoint("CSE104", 5));
            dataPoints5.Add(new DataPoint("CSE201", 4));
            dataPoints5.Add(new DataPoint("CSE203", 4));
            dataPoints5.Add(new DataPoint("CSE204", 3));
            dataPoints5.Add(new DataPoint("CSE210", 5));

            //dataPoints3.Add(new DataPoint("SEMESTER1", 38));
            //dataPoints3.Add(new DataPoint("SEMESTER2", 46));
            //dataPoints3.Add(new DataPoint("SEMESTER3", 55));
            //dataPoints3.Add(new DataPoint("SEMESTER4", 70));
            //dataPoints3.Add(new DataPoint("SEMESTER5", 77));
            //dataPoints3.Add(new DataPoint("SEMESTER6", 91));

            ViewBag.DataPoints4 = JsonConvert.SerializeObject(dataPoints4);
            ViewBag.DataPoints5 = JsonConvert.SerializeObject(dataPoints5);
            //ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataPoints3);
            return View();
        }


        //public ActionResult StudentList()
        //{
        //    //var studentList = db.Students.ToList();
        //    return View(db.Students.ToList());
        //}
    }
}