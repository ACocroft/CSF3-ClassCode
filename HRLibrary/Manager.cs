using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public sealed class Manager : SalariedEmployee
    {
        public decimal YearlyBonus { get; set; }

        public Manager(string firstName, string lastName, DateTime dob, int id, string jobTitle, DateTime dateOfHire, bool isDirectDeposit, decimal yearlySalary, decimal yearlyBonus) : base(firstName, lastName, dob, id, jobTitle, dateOfHire, isDirectDeposit, yearlySalary)
        {
            YearlyBonus = yearlyBonus;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nBonus: {YearlyBonus:c}";
        }
    }
    //cannae derive from sealed types
}
