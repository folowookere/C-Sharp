// Demo 34 Enums

using System;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            //if you get value from another part in the code you can cast shippingmethod onto it
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            //Can convert method to a string
            Console.WriteLine(method.ToString());

            var methodName = "Express";

            // Parsing a string to an enum
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        }
    }
}
