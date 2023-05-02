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

        //By default, we inherit the GetPaycheckAmount functionality from SalariedEmployee, so we don't get
        //a not implemented error.
        public override decimal GetPayCheckAmount()
        {
            //return base.GetPayCheckAmount();
            //Bonuses can be distributed a variety of ways. GATHER REQUIREMENTS BY ASKING.
            //We're saying managers are paid monthly, and their bonuses are distributed evenly throughout the year.
            return (YearlySalary + YearlyBonus) / 12;
        }
    }
    //cannae derive from sealed types
}
