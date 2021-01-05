using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IubObe.Web.Controllers
{
    public class ReadExcelDataController : Controller
    {
        // GET: ReadExcelData
        public ActionResult Index()
        {
            string con =
              @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Desktop\CSE303 OBE Mark Sheet.xlsx;" +
              @"Extended Properties='Excel 8.0;HDR=Yes;'";
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [Verdict$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var row1Col0 = dr[0];
                        Console.WriteLine(row1Col0);
                    }
                }
            }

            return View();
        }
    }
}