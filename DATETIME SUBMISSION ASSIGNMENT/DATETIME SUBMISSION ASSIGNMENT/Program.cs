using System;

namespace DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints current date and time
            Console.WriteLine("Current date and time: " + DateTime.Now);

            // Asks user for a number
            Console.WriteLine("Please enter a number of hours:");
            int hours = Convert.ToInt32(Console.ReadLine());

            // Adds hours to the current time
            DateTime futureTime = DateTime.Now.AddHours(hours);

            // Prinst the future time
            Console.WriteLine("In " + hours + " hours, the time will be: " + futureTime);

            Console.ReadLine();
        }
    }
}