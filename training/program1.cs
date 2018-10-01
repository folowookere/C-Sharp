using System;
using System.Text;

namespace FirstConsoleApp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Wecome to c# Essential Training Part 1");
            //Console.WriteLine("Press enter to continue.");
            //Console.ReadLine();

            //string firstString = "This is my first string variable";
            //Console.WriteLine(firstString);

            //var secondString = "This is my second string.";
            //Console.WriteLine(secondString);

            //var firstString = "test 123";
            //var firstChar = 'A';
            //int firstInt = 5;
            //var secondInt = 6;
            //int bigInt = int.MaxValue;
            //uint bigPositiveInt = uint.MaxValue;
            //Console.WriteLine(bigInt);
            //Console.WriteLine(bigPositiveInt);

            //short smallerNumber = 5;
            //long biggerNumber = 234343234234295865;
            //ulong uLong = ulong.MaxValue;

            ////f at end specifies float
            //float pi = 3.14f;
            //var pi = 3.14f;
            //double pi2 = 3.14;

            ////d at end specifies double
            //var pi3 = 3.14d;

            //bool personalTruth = true;
            //var thisIsFalse = false;

            //int.Parse("20");
            //var test = "abcde";
            //Console.WriteLine(test.ToUpper());

            //var testString = " abCDefg  ";
            //Console.WriteLine(testString.Trim());

            //var password = "P@ssw0rd";
            //Console.WriteLine(password.ToUpper());

            //var dickens = "It was the best of times, it was the worst of times.";
            ////first overload is index, second is length
            //Console.WriteLine(dickens.Substring(4, 8)); 

            ////finding length of string
            ////dickens.Length();

            //var challenge = "  Text processing in C# is really great! ";

            //Console.WriteLine(challenge.Trim().Substring(24, challenge.Trim().Length - 25).ToUpper().Trim());

            //Concatenation
            //var stringOne = "Hello ";
            //var stringTwo = "I love you ";
            //var stringThree = "Won't you tell me your name?";
            //Console.WriteLine(stringOne + stringTwo + stringThree);


            //Using string builder to put long strings together
            //    var sb = new StringBuilder();
            //    sb.Append("It was the best of times, it was the worst of times.");
            //    sb.Append("it was the age of wisdom");
            //    sb.Append("it was the age of foolishness");
            //    sb = new StringBuilder("It was the best of times, it was the worst of times.");
            //    sb.AppendLine("it was the age of wisdom");
            //    sb.AppendLine("it was the age of foolishness");
            //    Console.WriteLine(sb.ToString());
            //}

            var city = "Providence";
            var temperature = 70.4f;
            var currentDt = DateTime.Now;
            temperature = 90343.3f;
            Console.WriteLine(string.Format("Welcome to {0}. The time is {1:T}. The temp is {2:0,0.00}.", city, currentDt, temperature));

            var test = "15,234";
            Console.WriteLine(int.Parse(test.Replace(",", "")));

            int result;
            Console.WriteLine(int.TryParse("15234", out result)); 
            Console.WriteLine(result);
        }

    }
}
