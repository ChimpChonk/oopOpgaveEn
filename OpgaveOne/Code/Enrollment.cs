using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveOne.Code
{
    internal class Enrollment
    {
        public Students StudentInfo { get; set; }
        public Course CoursesInfo { get; set; }
        public List<Enrollment> EnrollList { get; set; }

        public Enrollment(Students _studentInfo, Course _coursesInfo)
        {
            StudentInfo = _studentInfo;
            CoursesInfo = _coursesInfo;
        }

        public Enrollment()
        {
        }
        
    }
}
