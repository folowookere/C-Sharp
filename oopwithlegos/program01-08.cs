using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var man = new Man();
            var kart = new Kart();
            var alien = new Alien();
        }
    }

    public class GeneralObject
    {
        public GeneralObject () {
        }
        public bool moves { get; set; }
        public string color { get; set; }

    }

    public class Human : GeneralObject
    {
        public Human ()
        {}
            public string name { get; set; }
    }

    // Class, does nothing until it's instantiated
    public class Man : Human
    {
        public Man() {
        }

        // Constructor
        public string name { get; set; }
    }

    public class Woman : Human
    {
        public Woman () {
            
        }
    }

    public class Kart : GeneralObject
    {
        public Kart () {
        }

        public string manufacturer { get; set; }
    }

    public class Alien : GeneralObject
    {
        public Alien () {
        }

        public string planet { get; set; }
    }
}
