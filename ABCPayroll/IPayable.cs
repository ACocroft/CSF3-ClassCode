namespace ABCPayroll
{
    public interface IPayable
    {
        #region Interface Notes
        /* - This started as a free class when we created the class library.
    *    We overtyped the class declaration with the interface keyword.
    *  - Any class that wants to use this set of rules MUST Implement
    *    the interface at the class level AND satisfy the requirements
    *    in the body of the class. 
    *  - We can implement as many interfaces as are required as opposed
    *    to inheritance where we can only Inherit ONE CLASS directly. 
    *  - Implementation of the interface at the class level creates a 
    *    CONTRACT that says if you want to be "a kind of" the interface
    *    you MUST satisfy these requirements
    *  - Interfaces MUST be public.
    *  - IsomethingABLE is the naming convention (.NET)
    *  
    *  ********************* WHEN AND HOW ********************
    *  1. When you have objects that MUST conform to a set of rules/specifications
    *     AND there are no other obvious links, such as an inheritance chain, then an interface
    *     may be used.
    *     This gives you AND other devs a compiler-enforced set of rules.
    *     
    *  2. Create the interface structure, usually in their own class library
    *  
    *  3. Implement at the class level at the lowest level of commonality, ONLY on classes 
    *     that MUST conform to these specifications.
    *     
    *  4. Satisfy the requirements in the class body.
    *  
    *  5. TEST! Look for any logic errors (usually caused by inheritance or calculations)
    */
        #endregion

        //Our interface will only require methods. However, an interface CAN require specific properties,
        //fields, or CTORs as needed. 

        //funny
        //FIELDS


        //people
        //PROPERTIES


        //collect
        //CONSTRUCTORS


        //monkeys 
        //METHODS
        //Contract - method to get a name for the paycheck, and one to get the paycheck amount.
        string GetFullName();
        decimal GetPayCheckAmount();

        //We are missing:
        //the body
        //the access modifier
        //this contract is just saying you must have a method named "this" that returns "that"
        //the BEHAVIOR and the ACCESS LEVEL will be determined in the classes that implement this interface.


    }
}