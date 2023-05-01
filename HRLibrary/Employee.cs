using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    //make it public
    public abstract class Employee : Person
    {
        //No fields, just business rules
        public int ID { get; /*set;*/ }//setter removed to make it readonly. It can now only be set in the ctor.
        public string JobTitle { get; set; }
        public DateTime DateOfHire { get; set; }
        public bool IsDirectDeposit { get; set; }



        //The parent-compliant constructor - Right click on Employee > Quick actions > Generate Constructor
        protected Employee(string firstName, string lastName, DateTime dob,
            int id, string jobTitle, DateTime dateOfHire, bool isDirectDeposit) 
            : base(firstName, lastName, dob)
        {
            ID = id;
            JobTitle = jobTitle;
            DateOfHire = dateOfHire;
            IsDirectDeposit = isDirectDeposit;
        }
        public override string ToString()
        {
            return $"ID: {ID}\n" +
                   $"{base.ToString()}\n" +
                   $"Job Title: {JobTitle}\n" +
                   $"Date of Hire: {DateOfHire:d}\n" +
                   $"Direct Deposit: {(IsDirectDeposit ? "Yes" : "No")}";
        }

    }
}
