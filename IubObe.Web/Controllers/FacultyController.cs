using IubObe.Web.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IubObe.Web.Controllers
{
    public class FacultyController : Controller
    {
        private MainDataContext db = new MainDataContext();
        // GET: Faculty
        public ActionResult StudentList()
        {
            //var studentList = db.Students.ToList();
            return View(db.Students.ToList());
        }
    }
}