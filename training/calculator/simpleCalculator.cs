using System;

namespace SimpleCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string username = Console.ReadLine();

            if (username.Equals("Funmi"))
            {
                Console.WriteLine("Hello me!");
            }
            else if (username.Equals("Kofo"))
            {
                Console.WriteLine("Hello Kofo");
            }
            else
            {
                Console.WriteLine("Hello Nobody");
            }
        }
    }
}
