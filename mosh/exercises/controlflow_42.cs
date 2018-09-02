// Section 5: Control Flow - Exercises 42

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. If user enters number between 1-10 display valid 
            if not display invalid */

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number >= 1 && number <= 10)
            //{ 
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            // 2. Display larger of 2 numbers

            //Console.Write("Enter a number: ");
            //var firstNumber = int.Parse(Console.ReadLine());

            //Console.Write("Enter one more number: ");
            //var secondNumber = int.Parse(Console.ReadLine());

            //if (firstNumber > secondNumber)
            //{
            //    Console.WriteLine(firstNumber);
            //}

            //Console.WriteLine(secondNumber);

            // 3. Take width and height and say whether portrait or landscape

            //Console.Write("Enter a width: ");
            //var width = int.Parse(Console.ReadLine());

            //Console.Write("Enter a height: ");
            //var height = int.Parse(Console.ReadLine());

            //if (width > height)
            //{
            //    Console.WriteLine("Image is landscape.");
            //}

            //Console.WriteLine("Image is portrait.");

            // 4. Program for speed camera

            Console.Write("Please enter a speed limit: ");
            var speedLimit = int.Parse(Console.ReadLine());

            Console.Write("How fast was the car going? ");
            var speedOfCar = int.Parse(Console.ReadLine());
            var mphOver = speedOfCar - speedLimit;
            var demeritPoints = mphOver / 5;


            if (speedOfCar < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if (demeritPoints > 12)
             {
                Console.WriteLine("License Suspended");
             }
            else
            {
                Console.WriteLine(demeritPoints);
            }

        }
    }
}
