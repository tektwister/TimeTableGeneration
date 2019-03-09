using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TimeTable.Models
{
    public class user
    {
        [Required(ErrorMessage = "Enter Name: ")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter User Name: ")]
        public string username { get; set; }

        [Required(ErrorMessage = "Enter Password: ")]
        public string password { get; set; }
    }
}