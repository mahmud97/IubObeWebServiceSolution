
using IubObe.Web.ViewModels;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;

namespace IubObe.Web.Services
{
    public class ReadExcel
    {
        public void readDataFromExcel()
        {
            string con =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\IubObeWebServiceSolution\IubObe.Web\ResourceFiles\CSE303 OBE Mark Sheet.xlsx;" +
            @"Extended Properties='Excel 8.0;HDR=Yes;'";
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [Analysis$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var row1Col0 = dr[0];
                        var row1Col1 = dr[1];

                        Console.WriteLine(row1Col0);
                    }
                }
            }
        }
    }
}