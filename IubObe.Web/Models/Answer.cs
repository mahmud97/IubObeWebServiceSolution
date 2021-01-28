using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IubObe.Web.Models
{
    public class Answer: BaseEntity<string>
    {
        public float OMark { get; set; }
        public float FMark { get; set; }

        public string QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }

        public string EnrollId { get; set; }

        [ForeignKey("EnrollId")]
        public Enroll Enroll { get; set; }

        public string FacultyId { get; set; }

        [ForeignKey("FacultyId")]
        public Facult Facult { get; set; }
    }
}