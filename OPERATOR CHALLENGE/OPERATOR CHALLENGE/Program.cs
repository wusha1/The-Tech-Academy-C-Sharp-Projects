using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your favorite number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number != 10)
        {
            Console.WriteLine("Your number is not 10");
        }
        else
        {
            Console.WriteLine("Your number is 10");
        }

        Console.ReadLine();
    }
}