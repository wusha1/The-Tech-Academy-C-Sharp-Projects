using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        string result = (age >= 18) ? "You are an adult." : "You are a minor.";

        Console.WriteLine(result);

        Console.ReadLine();
    }
}