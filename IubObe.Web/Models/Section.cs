using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IubObe.Web.Models
{
    public class Section : BaseEntity<string>
    {
        public int SectionNo { get; set; }
        public string Semester { get; set; }
        public DateTime Year { get; set; }

        public string CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        public string FacultyId { get; set; }

        [ForeignKey("FacultyId")]

        public Facult Facult { get; set; }
        public virtual ICollection<Question> Questions { get; set; }

        public virtual ICollection<Enroll> Enrolls { get; set; }


    }
}