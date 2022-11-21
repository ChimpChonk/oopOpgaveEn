using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveOne.Code
{
    sealed class Students : Person
    {
        public int StudentId { get; set; }
        public Students(int _studentId, string _firstName, string _lastName, string _dateOfBirth) : base(_firstName, _lastName, _dateOfBirth)
        {
            StudentId = _studentId;
        }

    }
}
