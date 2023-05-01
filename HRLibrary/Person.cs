namespace HRLibrary
{
    //The abstract modifier indicates that this class has an incomplete implementation.
    //We cannot create an incomplete object.
    //Therefore, this class MUST be inherited in order to be instantiated in our program.
    public abstract class Person
    {
        //fields
        //naming convention : _camelCase
        //Conventions VS Rules:
        //Conventions SHOULD be followed (Boss Enforced)
        //Rules MUST be followed (Compiler Enforced)
        private string _firstName;
        private string _lastName;

        //readonly - returns data, but cain't set a value after initialization.
        private readonly DateTime _dob;
        //props
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value.Length > 0)
                {
                    _firstName = value;
                }
                else
                {
                    _firstName = "Not Given";
                }
            }
        }//end first name prop

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value.Length > 0 ? value : "Not Given";//ternary operator
            }
        }

        public DateTime DOB
        {
            get { return _dob; }
            //set { _dob = value; }//commented out for read only. it will be set in the constructor. Assign the field _dob there.
        }

        //CTOR. If we declare our own ctors, we lose the default one inherited from Object.
        //To use the default in this situation, we would need to recreate it.
        //More than one ctor is called overloaded
        //Conventions should be public - parameter names are camelCase.
        public Person(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            _dob = dob;//Having a readonly field allows us to ensure we are only able 
            //to give DOB a value in the CTOR
        }

        //public override string ToString()
        //{
        //    //return base.ToString();//Namespace.ClassName
        //    string response = "";
        //    //Concatenation:
        //    response = "Name: " + FirstName + " " + LastName + "\nDate of Birth: " + DOB.ToShortDateString();
        //    //String Format:
        //    string format = "Name: {0} {1}\nDate of Birth: {2:d}";
        //    response = string.Format(format, FirstName, LastName, DOB);
        //    //String Interpolation:
        //    response = $"Name: {FirstName} {LastName}\nDate of Birth: {DOB:d}";
        //    return response;
        //}
        //String Interpolation using LINQ
        //Language INtegrated Query is the name for a set of technologies introduced in .NET 3.5 that allowsw the
        //integration of Data Querying directly in C#.
        //The arrow => is not part of LINQ directly, but they were introduced at the same time and
        //LINQ relies heavily on it. I read it as "Resolves To"
        //Expression Syntax
        public override string ToString() => $"Name: {FirstName} {LastName}\nDate of Birth: {DOB:d}";
    }
}