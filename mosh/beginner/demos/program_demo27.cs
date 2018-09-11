// Demo on Classes

using System;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring new object with Person class
            var john = new Person();
            
            // Using dot notation
            john.FirstName = "John";
            john.LastName = "Smith";
            
            // Calling method on john object
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}

// Code below is in seperate c# file called person.cs, added here just to show how it works

using System;

namespace HelloWorld
{
    public class Person
    {
        // Fields
        public string FirstName;
        public string LastName;
        
        // Method called Introduce, doesn't return any values with void keyword
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}

