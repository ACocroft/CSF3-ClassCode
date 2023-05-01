using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class SalariedEmployee : Employee
    {

        //no fields

        //one prop
        public decimal YearlySalary { get; set; }

        public SalariedEmployee(string firstName, string lastName, DateTime dob, int id, string jobTitle, DateTime dateOfHire, bool isDirectDeposit, decimal yearlySalary) 
            : base(firstName, lastName, dob, id, jobTitle, dateOfHire, isDirectDeposit)
        {
            YearlySalary = yearlySalary;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nYearly Salary: {YearlySalary:c}";
        }
    }
}
