using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoitshokoStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudyGroup()
        {
            List<Models.Student>students = new List<Models.Student>();//Create list for the students
            students.Add(new Models.Student { Student_Number = "u24634400", StudentName = "Boitshoko", Surname = "Mphahlele", Email = "u24634400@tuks.co.za" });
            students.Add(new Models.Student { Student_Number = "u24784606", StudentName = "Msizi", Surname = "Gumede", Email = "u24784606@tuks.co.za" });
            students.Add(new Models.Student { Student_Number = "u24924718", StudentName = "Gundo", Surname = "Ndou", Email = "u24924718@tuks.co.za" });
            students.Add(new Models.Student { Student_Number = "u24717739", StudentName = "Ritshidze", Surname = "Nedzimauli", Email = "u24717739@tuks.co.za" });
            students.Add(new Models.Student { Student_Number = "u24758354", StudentName = "Nhlanhla", Surname = "Mnisi", Email = "u24758354@tuks.co.za" });


            return View(students);
        }

    }
}