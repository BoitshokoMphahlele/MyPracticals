using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoitshokoStudyGroup.Models
{
    public class Student
    {
        //This is the model of StudentData

        [Display(Name = "Student_Number")] //Adding Decorator
        public string Student_Number { get; set; }

        [Display (Name = "StudentName")] //Adding Decorator
        public string StudentName { get; set; }

        [Display (Name = "Surname")]
        public string Surname { get; set; }

        [Display (Name = "Email")]
        public string Email { get; set; }

        


    }
}