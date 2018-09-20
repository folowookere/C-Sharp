// Intermediate Section 2 Exercise: Classes - Stopwatch

using System;

namespace HelloWorld
{
    public class Stopwatch 
    {
        public bool alreadyStarted;

        public DateTime startTime;
        public DateTime endTime;

        public void Start()
        {
            if (alreadyStarted)
                throw new InvalidOperationException("Stopwatch is running already!");

            startTime = DateTime.Now;
            alreadyStarted = true;
        }

        public void Stop()
        {

            endTime = DateTime.Now;
            alreadyStarted = false;
            Duration();
            
        }

        public TimeSpan Duration()
        {
            var duration = endTime - startTime;
            Console.WriteLine(duration);

            return duration;

        }
    }

    class Program
    { 
        
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();

            while (true)
            {
                Console.WriteLine("Usage: Enter start, stop or quit...");
                var input = Console.ReadLine();

                if (input == "start")
                {
                    time.Start();
                    Console.Write("To stop timer enter 'stop'...");
                }

                else if (input == "stop")
                {
                    time.Stop();
                }

                else if (input == "quit")
                {
                    return;
                }

                else
                    Console.WriteLine("Please enter valid input.");
                    
            }

        }

    }

}