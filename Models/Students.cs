using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentList.Models
{
    public class Students
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string CouseId { get; set; }
        public Course EnrolledCourse {get; set;}
        public int CourseId { get; internal set; }
    }
}