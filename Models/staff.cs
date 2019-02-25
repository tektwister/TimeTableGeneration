using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TimeTable.Models
{
    public class staff
    {
        [Key]
        public int StaffId { get; set; }

        [Required(ErrorMessage = "Enter Staff Name")]
        public string StaffName { get; set; }
    }
}