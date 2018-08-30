using System;
using System.Text;


namespace DemosMosh2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var stringBuilder = new StringBuilder("Hello World");
            stringBuilder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Insert(0, new string('-', 10));

            //stringBuilder.Remove(0, 10);



            Console.WriteLine(stringBuilder);

            Console.WriteLine("First char: " + stringBuilder[0]);
        }
    }
}
