using System;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.WriteLine("Enter a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            int result1 = math.AddTen(userNumber);
            int result2 = math.MultiplyByTwo(userNumber);
            int result3 = math.SubtractFive(userNumber);

            Console.WriteLine("Add 10: " + result1);
            Console.WriteLine("Multiply by 2: " + result2);
            Console.WriteLine("Subtract 5: " + result3);

            Console.ReadLine();
        }
    }
}