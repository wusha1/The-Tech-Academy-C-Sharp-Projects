using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 10)
        {
            Console.WriteLine("The number is greater than 10.");
        }
        else if (number == 10)
        {
            Console.WriteLine("The number is exactly 10.");
        }
        else
        {
            Console.WriteLine("The number is less than 10.");
        }

        Console.ReadLine();
    }
}