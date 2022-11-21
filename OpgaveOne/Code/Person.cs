using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveOne.Code
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public int Age { get; set; }
        
        public Person(string _firstName, string _lastName, string _dateOfBirth)
        {
            FirstName = _firstName;
            LastName = _lastName;
            DateOfBirth = _dateOfBirth;
            Age = CalcAge(_dateOfBirth);
        }
        public int CalcAge(string dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
            DateTime _date = DateTime.ParseExact(dateOfBirth, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            int age = DateTime.Now.Year - _date.Year;
            return age;
        }

    }
}
