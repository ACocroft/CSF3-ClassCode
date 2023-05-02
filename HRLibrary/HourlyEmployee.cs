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

        public override decimal GetPayCheckAmount()
        {
            //throw new NotImplementedException();
            //local variable to represent the paycheck
            decimal paycheck;
            //assume that HourlyEmployees are paid 1.5 for every hour over 40, and they are paid weekly.
            if (HoursWorked <=40) 
            {
                paycheck = HourlyWage * HoursWorked;
            }
            else
            {
                //they earned OT
                decimal overtime = HoursWorked - 40;//subtract 40 to find total amount of EXTRA hours
                paycheck = (40 * HourlyWage) + (overtime * HourlyWage * 1.5m);
            }
            return paycheck;
        }

    }
}
