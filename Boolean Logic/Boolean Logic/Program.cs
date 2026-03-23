using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Have you ever had a DUI? (true/false)");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("How many speeding tickets do you have?");
        int tickets = Convert.ToInt32(Console.ReadLine());

        // Qualification rules
        bool qualified = (age > 15 && !hasDUI && tickets <= 3);

        Console.WriteLine("Qualified?");
        Console.WriteLine(qualified);

        Console.ReadLine();
    }
}