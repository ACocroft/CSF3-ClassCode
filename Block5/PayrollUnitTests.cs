using HRLibrary;
using Xunit;

namespace Block5
{
    public class PayrollUnitTests
    {
        [Fact]//signifies that this is a method the Test Runner can run.
        public void TestAdd()
        {
            //Arrange - set up environment. Variables/objects, using statements, etc. (plan the attack)
            int a = 13;
            int b = 29;
            //Act = do the thing we're testing. (strike)
            int actual = Calculator.Add(a, b);
            int expected = a + b;
            //Assert - declare what we think the outcome should be (enforce your views)
            Assert.Equal(expected, actual);//we are asserting that these two values will be equal. Expected and C
        }

        //Need to test GetPaycheckAmount for an Hourly Employee
        [Fact]
        public void TestHourlyPaycheck()
        {
            //Arrange
            HourlyEmployee he = new("Johnnard", "Five", new DateTime(1988, 10, 21), 222,
                "Robot Sidekick", new DateTime(2023, 1, 1), false, 40, 11.95m);
            decimal expected = 478;
            //Act
            decimal actual = he.GetPayCheckAmount();
            //Assert
            Assert.Equal(expected, actual);
        }

        //Test a salaried employee paper check
        [Fact]
        public void TestSalariedPaycheck()
        {
            //Arrange
            SalariedEmployee se = new("Cactulon", "Jackulon", new DateTime(), 333, "Security man", new DateTime(), true, 52000);
            //2000 per paycheck
            decimal expected = 2000m;
            //Act
            decimal actual = se.GetPayCheckAmount();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestManagerPaycheck()
        {
            //arrange (use for min/max damage in dungeon
            Manager m = new Manager("Henry", "Zebrowski",
                new DateTime(1985, 5, 3), 444, "Owner",
                new DateTime(2011, 1, 1), true, 150000, 25000);
            //14,583.33
            decimal expected = 14583.33m;
            decimal expected2 = (150000 + 25000) / 12;
            decimal expected3 = (m.YearlySalary + m.YearlyBonus) / 12;
            //act
            //We need to edit the employee classes to return round numbers
            decimal actual = Math.Round(m.GetPayCheckAmount(),2);
            //assert
            //BAD PRACTICE, you shouldn't do this. Think of the scientific method because you shouldn't change the test to suit what you want
            Assert.Equal(expected, actual);
            //The below is written backwards just to show the InRange()
            //Expected 3 is just ...33333333, actual is just .33
            Assert.InRange(expected3, actual, actual + .009m);
            //Again, do NOT do this. It's like shaving the corners off a square to make it fit in a circle hole.
        }

        [Theory]//lets us use InLineData (or other data sources) to run the test with various arguments.
        [InlineData(2,3,5)]//a, b, expected
        [InlineData(5,7,12)]
        [InlineData(0,0,0)]
        public void TestAddWithInLine(int a, int b, int expected)
        {
            int actual = Calculator.Add(a,b);
            Assert.Equal(expected, actual);
        }
    }
    internal class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}