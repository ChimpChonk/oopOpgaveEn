using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveOne.Code
{
    sealed class Teachers : Person
    {
        public string Department { get; set; }
        public Teachers(string _department, string _firstName, string _lastName, string _dateOfBirth) : base(_firstName, _lastName, _dateOfBirth)
        {
            Department = _department;
        }
    }
}
