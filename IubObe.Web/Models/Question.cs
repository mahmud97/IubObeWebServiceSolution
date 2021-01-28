using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IubObe.Web.Models
{
    public class Question : BaseEntity<string>
    {
        public string QuestionName { get; set; }
        public float OMark { get; set; }
        public float FMark { get; set; }

        public string SectionId { get; set; }

        [ForeignKey("SectionId")]
        public Section Section { get; set; }
        public string FacultyId { get; set; }

        [ForeignKey("FacultyId")]
        public Facult Facult { get; set; }

        public string CoId { get; set; }

        [ForeignKey("CoId")]

        public CO CO { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}