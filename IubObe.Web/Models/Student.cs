using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IubObe.Web.Models
{
    public class Student
    {
		[Required(ErrorMessage = "You must provide Name")]
		[DisplayName("Name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "You must provide an Email address")]
		[DisplayName("Email")]
		[EmailAddress]
		public string Email { get; set; }


		[Required(ErrorMessage = "You must provide your Student Id")]
		[DisplayName("Student Id")]
		public string StudentId { get; set; }

		[Required(ErrorMessage = "You must provide Course Id")]
		[DisplayName("Course Id")]
		public string CourseId { get; set; }

		[Required(ErrorMessage = "You must provide Section")]
		[DisplayName("Section")]
		public int Section { get; set; }

		[Required(ErrorMessage = "You must provide Semester")]
		[DisplayName("Semester")]
		public string Semester { get; set; }

	}
}