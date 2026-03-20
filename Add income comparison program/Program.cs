using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");

        // Person 1
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate?");
        decimal rate1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Hours worked per week?");
        decimal hours1 = Convert.ToDecimal(Console.ReadLine());

        // Person 2
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate?");
        decimal rate2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Hours worked per week?");
        decimal hours2 = Convert.ToDecimal(Console.ReadLine());

        // Annual salaries
        decimal salary1 = rate1 * hours1 * 52;
        decimal salary2 = rate2 * hours2 * 52;

        // Output salaries
        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(salary1);

        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(salary2);

        // Comparison
        bool person1More = salary1 > salary2;

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(person1More);
    }
}