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
            return RedirectToAction("PloView");

            //var facultyExist = FacultyList.Where(u => u.Equals(model.Email)).FirstOrDefault();
            //if (facultyExist == null)
            //{
            //    ModelState.AddModelError("error", "This is not a faculty email address");
            //    return View();

               
            //}
            //return RedirectToAction("PloView");

        }
        public ActionResult PloView()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();

            dataPoints.Add(new DataPoint("PO2", 43));
            dataPoints.Add(new DataPoint("PO3", 46));
            dataPoints.Add(new DataPoint("PO4", 31));
            dataPoints.Add(new DataPoint("PO6", 56));

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

            return View();
        }

        //public ActionResult StudentList()
        //{
        //    //var studentList = db.Students.ToList();
        //    return View(db.Students.ToList());
        //}
    }
}