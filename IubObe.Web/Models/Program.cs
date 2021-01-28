using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IubObe.Web.Models
{
    public class Program: BaseEntity<string>
    {
        
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<PLO> PLOs { get; set; }
    }
}