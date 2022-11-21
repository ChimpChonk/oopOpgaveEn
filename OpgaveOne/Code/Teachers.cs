using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveOne.Code
{
    internal class Teachers : Person
    {
        public string Department { get; set; }
        AgeCalculate age = new();
        public Teachers(string _department, string _firstName, string _lastName, string _dateOfBirth)
        {
            Department = _department;
            FirstName = _firstName;
            LastName = _lastName;
            DateOfBirth = _dateOfBirth;
            Age = age.CalcAge(DateOfBirth);
        }
    }
}
