using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IubObe.Web.Models
{
    public class Faculty
    {

		[DisplayName("Faculty Id")]
		public int FacultyId { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "You must provide an Email address")]
        [DisplayName("Email")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "You must provide Password")]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }






    }
}