using NPOI.SS.UserModel;

using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IubObe.Web.ViewModels;

namespace IubObe.Web.Controllers
{
    public class ReadExcelDataController : Controller
    {
        // GET: ReadExcelData
        //public ActionResult Index()
        //{
        //    //string con =
        //    //  @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\IubObeWebServiceSolution\IubObe.Web\ResourceFiles\CSE303 OBE Mark Sheet.xlsx;" +
        //    //  @"Extended Properties='Excel 8.0;HDR=Yes;'";

        //    //using (OleDbConnection connection = new OleDbConnection(con))
        //    //{
        //    //    connection.Open();
        //    //    OleDbCommand command = new OleDbCommand("select * from [Verdict$]", connection);
        //    //    using (OleDbDataReader dr = command.ExecuteReader())
        //    //    {
        //    //        while (dr.Read())
        //    //        {
        //    //            var row1Col0 = dr[0];
        //    //            var row1Col1 = dr[1];

        //    //            Console.WriteLine(row1Col0);
        //    //        }
        //    //    }
        //    //}
        //    string localPath = @"D:\IubObeWebServiceSolution\IubObe.Web\ResourceFiles\CSE303 OBE Mark Sheet.xlsx";
        //    int sheetIndex = 1;
        //    Execute(localPath, sheetIndex);
        //    return View();
        //}

        //public void Execute(string localPath, int sheetIndex)
        //{
        //    IWorkbook workbook;
        //    using (FileStream file = new FileStream(localPath, FileMode.Open, FileAccess.Read))
        //    {
        //        workbook = WorkbookFactory.Create(file);
        //    }

        //    var importer = new Mapper(workbook);
        //    var items = importer.Take<StudentMarksAnalysis>(sheetIndex);
        //    foreach (var item in items)
        //    {
        //        var row = item.Value;
        //        if (string.IsNullOrEmpty(row.EmailAddress))
        //            continue;

        //        UpdateUser(row);
        //    }

        //    DataContext.SaveChanges();
        //}

    }
}