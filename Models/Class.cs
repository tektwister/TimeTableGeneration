using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TimeTable.Models
{
    public class Class
    {
        //[Key]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassId { get; set; }

        [Required(ErrorMessage = "Enter Class Name")]
        public string ClassName { get; set; }

        [Required(ErrorMessage = "Enter Class Venue")]
        public string Venue { get; set; }
    }
}