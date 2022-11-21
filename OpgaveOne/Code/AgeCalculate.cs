using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveOne.Code
{
    internal class AgeCalculate : Person
    {
        public AgeCalculate()
        {

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
