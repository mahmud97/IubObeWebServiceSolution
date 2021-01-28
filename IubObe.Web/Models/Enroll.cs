using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IubObe.Web.Models
{
    public class Enroll: BaseEntity<string>
    {
        public string SectionId { get; set; }

        [ForeignKey("SectionId")]
        public Section Section { get; set; }

        public string StudentId { get; set; }

        [ForeignKey("StudentId")]

        public Student Student { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}