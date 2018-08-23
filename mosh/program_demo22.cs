// Demo Operators

using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            // C is greater than b or if c is equal to a, should return false.
            Console.WriteLine(!( c > b || c == a));

        }
    }
}
