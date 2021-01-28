using IubObe.Web.DB;
using IubObe.Web.Models;
using IubObe.Web.ViewModels;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IubObe.Web.Controllers
{
    public class StudentController : Controller
    {

        private MainDataContext db = new MainDataContext();
        // GET: Student
        public ActionResult StudentRegistration()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult StudentRegistration(Student model, string button)
        {

            string sendGridKey = CoreAppSettings.SendGridApiKey;

            if (button == "Cancel")
            {

                ModelState.Clear();
                return View();

            }
            var emailExist = db.Students.Where(s => s.Email == model.Email).FirstOrDefault();
            //var studentExist = db.Students.Where(s => s.StudentId == model.StudentId).FirstOrDefault();
            //if (studentExist != null)
            //{
            //    ModelState.AddModelError("error1", "This Student Id already exists");
            //    return View();
            //}

            if (emailExist != null)
            {
                ModelState.AddModelError("error2", "This email already exists");
                return View();
            }
           

            if (ModelState.IsValid)
            {
                db.Students.Add(model);
                db.SaveChanges();
                SendMail(model, sendGridKey);
                return RedirectToAction("Thanks", "Student");
            }

            return View(model);
        }

        public ActionResult StudentDetails(string uniqueIdentifier)
        {
            if (string.IsNullOrEmpty(uniqueIdentifier))
                return HttpNotFound();

           
           // var result = db.Students.SingleOrDefault(c => c.StudentId.Equals(uniqueIdentifier));

            
            return View("StudentDetails");

        }

        public ActionResult Thanks()
        {
            return View();
        }
        private void SendMail(Student model, string key)
        {
            try
            {
                var apikey = key;
                var client = new SendGridClient(apikey);
                var from = new EmailAddress(model.Email);
                var subject = model.Name + "'s registration information";
                var to = new EmailAddress(CoreAppSettings.MailTo);
                var plainTextContent = "";
                var htmlContent = "<p> Name: " + model.Name + "</p>";
                htmlContent = htmlContent + "<p> Email: " + model.Email + "</p>";
               // htmlContent = htmlContent + "<p> StudentId: " + model.StudentId + "</p>";
               // htmlContent = htmlContent + "<p> CourseId: " + model.CourseId + "</p>";
              //  htmlContent = htmlContent + "<p> Section: " + model.Section + "</p>";
              //  htmlContent = htmlContent + "<p> Semester: " + model.Semester + "</p>";
                var message = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = client.SendEmailAsync(message);
            }
            catch (Exception ex)
            {
                throw ex;
                //Log.Error("Error Sending Contact Form email.", ex);
            }
        }


    }
}