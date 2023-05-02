using ABCPayroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    //make it public
    //This is a public inheritance only class called employee that extends the person class and
    //implements the IPayable and IDirectDepositable interfaces.
    //You COULD remove the IPayable interface here, because IDirectDepositable inherits the requirements
    //of IPayable.
    public abstract class Employee : Person, IPayable, IDirectDepositable
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

        public string GetFullName()
        {
            //throw new NotImplementedException();
            return $"{FirstName} {LastName}";
        }
        //We don't have the necessary information to implement this method at this level. So,
        //we will pass it off to the child classes.
        public abstract decimal GetPayCheckAmount();
       
        public string GetBankingInfo()
        {
            //probably a whole other class library to handle banking info.
            //REQUIREMENTS GATHERING: Witholding, tax, 401k, split-disbursement, etc.

            return "Bank of 'Merica 000123 111222333444";
            //If this were production code, it wouldn't be hard-coded.
        }
    }
}
