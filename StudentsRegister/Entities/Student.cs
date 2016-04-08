using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsRegister.Entities
{
    public class Student
    {

        [HiddenInput(DisplayValue = false)]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Please enter a First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a Last name")]
        public string LastName { get; set; }

        [Required]
        [Range(0, 5, ErrorMessage = "Please enter a course between 1 and 4")]
        public int Course { get; set; }

        [Required(ErrorMessage = "Please enter a speciality")]
        public string Speciality { get; set; }

    }
}