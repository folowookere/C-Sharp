// Section 5: Control Flow - Exercises 48

using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Count numbers divisible by 3
            //var divisibleByThree = 0;
            //for (var i = 1; i <= 100; i++)
            //    if (i % 3 == 0)
            //{
            //        divisibleByThree++;
            //}
            //Console.WriteLine("All numbers divisible by 3 are: " + divisibleByThree);

            // 2. Add all previously entered numbers
            //var total = 0;


            //while(true)
            //{
            //    Console.Write("Enter a number or ok to exit: ");
            //    string currentNumber = Console.ReadLine();

            //    if (currentNumber == "ok")
            //        break;

            //    total += Convert.ToInt32(currentNumber);
            //} 
            //// Display total
            //Console.WriteLine("Your total is: " + total);

            // 3. Factorialize

            //int num = 5;
            //int newNum = 1;
            //for (int i = 1; i <= num; i++)
            //{
            //newNum = newNum * i;
            //Console.WriteLine(newNum);



            //4. Guess the random number


            //const int amountOfNumbers = 10;
            //var hold = new int[11];
            //Console.WriteLine("[{0}]", string.Join(", ", hold));
            //for (var i = 0; i <= amountOfNumbers; i++)

            //var random = new Random();
            //var randomNumber = random.Next(1, 10);


            //for (var i = 0; i < 4; i++)
            //{
            //    Console.Write("Guess the number: ");
            //    var guessedNumber = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(randomNumber);

            //    if (guessedNumber == randomNumber)
            //    {
            //        Console.WriteLine("You won!");
            //        return;
            //    }
            //}

            //Console.WriteLine("You lost!");
            //}

            // 5. Display largest number

            Console.Write("Enter a series of numbers separated by commas: ");
            var numbers = Console.ReadLine();
            var eachNumber = numbers.Split(',');
            List<string> numbersList = new List<string>(eachNumber);
            var individualMaxNumber = Convert.ToInt32(eachNumber[0]);

            foreach (var str in eachNumber)
            {
                var number = Convert.ToInt32(str);
                if (number > individualMaxNumber)
                    individualMaxNumber = number;
            }
            Console.WriteLine("Largest number is: " + individualMaxNumber);


        }

    }

}