using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IubObe.Web.Models
{
    public class Facult: BaseEntity<string>
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Section> Sections { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }


    }
}