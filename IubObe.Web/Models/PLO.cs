using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IubObe.Web.Models
{
    public class PLO: BaseEntity<string>
    {
        public int PlNo { get; set; }
        public float OMark { get; set; }
        public float  FMark { get; set; }
        [Required]
        public string ProgramId { get; set; }

        [ForeignKey("ProgramId")]
        public Program Program { get; set; }

        public virtual ICollection<CO> COs { get; set; }
    }
}