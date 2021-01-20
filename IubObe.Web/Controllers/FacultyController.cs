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
            return View();
        }

        public ActionResult CPV()
        {
            List<DataPoint> dataPoints1 = new List<DataPoint>();
            List<DataPoint> dataPoints2 = new List<DataPoint>();
            List<DataPoint> dataPoints3 = new List<DataPoint>();

            dataPoints1.Add(new DataPoint("Jan", 72));
            dataPoints1.Add(new DataPoint("Feb", 67));
            dataPoints1.Add(new DataPoint("Mar", 55));
            dataPoints1.Add(new DataPoint("Apr", 42));
            dataPoints1.Add(new DataPoint("May", 40));
            dataPoints1.Add(new DataPoint("Jun", 35));

            dataPoints2.Add(new DataPoint("Jan", 48));
            dataPoints2.Add(new DataPoint("Feb", 56));
            dataPoints2.Add(new DataPoint("Mar", 50));
            dataPoints2.Add(new DataPoint("Apr", 47));
            dataPoints2.Add(new DataPoint("May", 65));
            dataPoints2.Add(new DataPoint("Jun", 69));

            dataPoints3.Add(new DataPoint("Jan", 38));
            dataPoints3.Add(new DataPoint("Feb", 46));
            dataPoints3.Add(new DataPoint("Mar", 55));
            dataPoints3.Add(new DataPoint("Apr", 70));
            dataPoints3.Add(new DataPoint("May", 77));
            dataPoints3.Add(new DataPoint("Jun", 91));

            ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataPoints1);
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataPoints2);
            ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataPoints3);
            return View();
        }


        //public ActionResult StudentList()
        //{
        //    //var studentList = db.Students.ToList();
        //    return View(db.Students.ToList());
        //}
    }
}