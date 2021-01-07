using IubObe.Web.DB;
using IubObe.Web.ViewModels;
using Microsoft.Ajax.Utilities;
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
        public ActionResult FacultyLogin(FacultyLoginVM model, string button)
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

            var facultyExist = FacultyList.Where(u => u.Equals(model.Email)).FirstOrDefault();
            if (facultyExist == null)
            {
                ModelState.AddModelError("error", "This is not a faculty email address");
                return View();

               
            }
            return RedirectToAction("StudentList");

        }

        public ActionResult StudentList()
        {
            //var studentList = db.Students.ToList();
            return View(db.Students.ToList());
        }
    }
}