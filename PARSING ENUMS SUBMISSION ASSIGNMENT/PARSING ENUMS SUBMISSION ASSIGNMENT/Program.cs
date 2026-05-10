using System;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user to type in a day
                Console.WriteLine("Enter the current day of the week:");

                // Save what the user typed
                string userInput = Console.ReadLine();

                // Turn the user's input into an enum value
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userInput);

                // Print the result to the console
                Console.WriteLine("Today is: " + day);
            }
            catch
            {
                // This runs if the user types something invalid
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }

    // Days of the week enum
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}