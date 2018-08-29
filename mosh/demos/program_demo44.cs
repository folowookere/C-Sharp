// Demo 44 Iterations

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //For loops
            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Same code using while loop
            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //    i++;
            //}

            // While loop
            //while (true)
            //{
            //    Console.Write("Type your name: ");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo: " + input);
            //        //Continue from while loop
            //        continue;
            //    }

            //    break;
            //}

            // Use of random number generator
            var random = new Random();

            // Set constant instead for length of password
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            
            //for as long as i is less than the password length
            for (var i = 0; i < passwordLength; i++)
                
                buffer[i] = (char)('a' + random.Next(0, 26));
                
            //store characters in password variable    
            var password = new string(buffer);
            
            //display random characters in console
            Console.WriteLine(password);

            //for (var i = 10; i >= 1; i--)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            // Display each letter of the string on a new line
            //var name = "John Smith";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //same result using foreach loop, no need for counter
            //foreach (var character in name)
            //{
            //    Console.WriteLine(character);
            //}


            //iteriate over array of numbers using foreach
            //var numbers = new int[] { 1, 2, 3, 4 };

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
          
        }

    }
}
