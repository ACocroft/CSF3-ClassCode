namespace Block4
{
    class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string MembershipType { get; set; }
        public DateTime SignedUp { get; set; }

        public Customer(int id, string firstName, string lastName, string phone, string email, string address,
            string city, string state, string zipcode, string country, string membershipType, DateTime signedUp)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Address = address;
            City = city;
            State = state;
            Zipcode = zipcode;
            Country = country;
            MembershipType = membershipType;
            SignedUp = signedUp;
        }

        public override string ToString()
        {
            return string.Format($"ID: {ID}\nName: {FirstName} {LastName}\nContact: ph - {Phone} email - {Email}\n" +
                $"{Address}, {City}, {State} {Zipcode} {Country}\nMembership: {MembershipType} since {SignedUp:d}");
        }
    }
    internal class LinqLab
    {
        static void Main(string[] args)
        {
            #region Customers

            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, "Bob", "Smithshire", "123-245-9960", "bobbieontheshire@gmail.com", "123 ABC Street", "Atlanta", "GA", "33045", "United States", "Standard", new DateTime(2019, 01, 05)),
                new Customer(5, "Callie", "Troop", "123-245-9960", "callie@aol.com", "123 ABC Street", "Montreal", "Quebec", "A1G5", "Canada", "Platinum", new DateTime(2015, 01, 25)),
                new Customer(3, "Lana", "Smith", "123-245-9960", "lanaSmith@outlook.com", "123 ABC Street", "Memphis", "TN", "34056", "United States", "Gold", new DateTime(2021, 04, 05)),
                new Customer(2, "Kyle", "Jones", "", "kyle@gmail.com", "123 ABC Street", "Nowhere", "KS", "33026", "United States", "Standard", new DateTime(2021, 11, 15)),
                new Customer(4, "Cora", "Zane", "123-245-9960", "czane@hotmail.com", "123 ABC Street", "Cincinnati", "OH", "33496", "United States", "Standard", new DateTime(2000, 03, 07)),
            };
            #endregion

            //1.    Provide a list of all customers listed alphabetically by last name.        
            //Method Syntax

            //Keyword Syntax


            //2.    Provide a list of customers in the United States.
            //Method Syntax

            //Keyword Syntax

            //3.    Provide a list of customers whose email is through google.
            //Method Syntax

            //Keyword Syntax

            //4.    Provide a list of customers who have been customer for more than 5 years.
            //Method Syntax

            //Keyword Syntax

            //5.    List customers who have provided a phone number. 
            //Method Syntax

            //Keyword Syntax

            //6.    List customers who have a membership type of gold or platinum.
            //Method Syntax
            //Keyword Syntax
            //7.    Provide a list of customers that have smith somewhere in their last name.
            //Method Syntax

            //Keyword Syntax

            //8.    Provide a list of customers ordered customer ID. 
            //Method Syntax

            //Keyword Syntax

        }
    }
}