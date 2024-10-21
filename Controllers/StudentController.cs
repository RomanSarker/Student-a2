using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentList.Models; 
namespace StudentList.Controllers
{
    public class StudentController : Controller
    {
        
        public ActionResult Index()
        {
            
            Teacher teacher1 = new Teacher { TeacherId = 1, Name = "Mr. Nafiur Islam" };
            Course course1 = new Course { CourseId = 1, CourseName = ".Net Core", TeacherId = 1, CourseTeacher = teacher1 };

            Teacher teacher2 = new Teacher { TeacherId = 2, Name = "Mr. Supporter" };
            Course course2 = new Course { CourseId = 2, CourseName = ".Net Framework", TeacherId = 2, CourseTeacher = teacher2 };

            Teacher teacher3 = new Teacher { TeacherId = 3, Name = "Mrs. Supporter22" };
            Course course3 = new Course { CourseId = 3, CourseName = "C### and Angular", TeacherId = 3, CourseTeacher = teacher3 };

            List<Students> students = new List<Students>
            {
                new Students { StudentId = 1, Name = "Roman", CourseId = 1, EnrolledCourse = course1 },
                new Students { StudentId = 2, Name = "Sarker", CourseId = 2, EnrolledCourse = course2 },
                new Students { StudentId = 3, Name = "Dalas", CourseId = 3, EnrolledCourse = course3 }

            };

            return View(students);  
        }
    }
}
