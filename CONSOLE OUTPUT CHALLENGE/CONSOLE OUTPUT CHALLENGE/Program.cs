using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Greater than >
        if (number > 10)
        {
            Console.WriteLine("Your number is greater than 10.");
        }

        // Less than or equal to <=
        if (number <= 10)
        {
            Console.WriteLine("Your number is less than or equal to 10.");
        }

        Console.ReadLine();
    }
}