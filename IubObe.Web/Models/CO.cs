using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IubObe.Web.Models
{
    public class CO: BaseEntity<string>
    {
        public float OMark { get; set; }
        public float FMark { get; set; }

        [Required]
        public string PloId { get; set; }

        [ForeignKey("PloId")]
        public PLO PLO { get; set; }


        [Required]
        public string CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        public virtual ICollection<Question> Questions { get; set; }

    }
}