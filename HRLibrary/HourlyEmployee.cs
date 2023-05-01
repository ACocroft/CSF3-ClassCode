using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    //Marking a class as sealed terminates the inheritance chain. This class cannot be a parent.
    public sealed class HourlyEmployee : Employee
    {
        //no fields here, homeslice
        //props tho
        public decimal HoursWorked { get; set; }
        public decimal HourlyWage { get; set; }

        //ctors
        public HourlyEmployee(string firstName, string lastName, DateTime dob, int id, string jobTitle, DateTime dateOfHire, bool isDirectDeposit, decimal hoursWorked, decimal hourlyWage)
            : base(firstName, lastName, dob, id, jobTitle, dateOfHire, isDirectDeposit)
        {
            HoursWorked = hoursWorked;
            HourlyWage = hourlyWage;
        }
        //ToString()
        public override string ToString() =>
            $"{base.ToString()}\nHours Worked: {HoursWorked:f2}\nHourly Wage: {HourlyWage:c}";
    }
}
