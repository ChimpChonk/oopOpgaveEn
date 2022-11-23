using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveOne.Code
{
    internal class Course
    {
        public string CourseName { get; set; }

        public Teachers Teachers { get; set; }

        public Course(string _courseName, Teachers _teachers)
        {
            CourseName = _courseName;
            Teachers = _teachers;
        }
        
    }

}
