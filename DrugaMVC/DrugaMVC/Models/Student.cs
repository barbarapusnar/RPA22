using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DrugaMVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Ime je obvezen podatek")]

        public string StudentName { get; set; }
       
        [Range(5,50,ErrorMessage ="Med 5 in 50")]
        public int Age { get; set; }
    }
}