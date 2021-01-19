using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IubObe.Web.Controllers
{
    public class PloController : Controller
    {
        // GET: Plo
        public ActionResult Index()
        {
            return View();
        }
        List<string> Pos = new List<string>()
        {
            "PO2",
            "PO3",
            "PO4",
            "PO6",
        };

        List<double> Achieved = new List<double>()
        {
            43,
            46,
            31,
            56,
        };

        //public ActionResult PloChart()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public JsonResult GetChartData()
        //{
        //    var model = Pos.ToList();
        //    return Json(model.ToArray(), JsonRequestBehavior.AllowGet);
        //}
    }
}