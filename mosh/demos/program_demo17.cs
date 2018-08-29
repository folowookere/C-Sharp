// Demo Variables and Constants

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 represents first argument, 1 represents second argument
            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}", float.MinValue, byte.MaxValue);

            // Cannot change value of constants
            const float Pi = 3.14f;
           // Compiler will not accept this --> Pi = 1;
            Console.WriteLine(Pi);
        }
    }
}
