using System;
using System.Collections.Generic;

namespace DemosMosh
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Trim method
            var fullName = "Funmi Olowookere ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());

            // ToUpper method
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            // IndexOf and Substring
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last name: " + lastName);

            // Split method
            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            // Replace method
            Console.WriteLine(fullName.Replace("Funmi", "Olufunmilayo"));

            if (String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));

        }
    }
}
