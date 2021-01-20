using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IubObe.Web.ViewModels
{
    public class StudentMarksAnalysis
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("Course ID")]

        public string CourseId { get; set; }
        //public int Section { get; set; }
        //public string Semester { get; set; }
        //public double Marks { get; set; }

        //public string PF { get; set; }
    }
}