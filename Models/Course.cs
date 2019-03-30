using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TimeTable.Models
{
    public class Course
    {
        [Required(ErrorMessage = "Enter Course Code")]
        public string CourseCode { get; set; }

        [Required(ErrorMessage = "Enter Course Name")]
        public string CourseName { get; set; }
    }
}