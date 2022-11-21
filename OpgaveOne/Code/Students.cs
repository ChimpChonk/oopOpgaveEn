using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveOne.Code
{
    internal class Students : Person
    {
        public int StudentId { get; set; }
        AgeCalculate age = new();
        public Students(int _studentId, string _firstName, string _lastName, string _dateOfBirth)
        {
            StudentId = _studentId;
            FirstName = _firstName;
            LastName = _lastName;
            DateOfBirth = _dateOfBirth;
            Age = age.CalcAge(DateOfBirth);

        }

    }
}
