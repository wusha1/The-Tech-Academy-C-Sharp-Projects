using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.WriteLine("Enter a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add 10: " + math.AddTen(userNumber));
            Console.WriteLine("Multiply by 2: " + math.MultiplyByTwo(userNumber));
            Console.WriteLine("Subtract 5: " + math.SubtractFive(userNumber));

            Console.ReadLine();
        }
    }
}