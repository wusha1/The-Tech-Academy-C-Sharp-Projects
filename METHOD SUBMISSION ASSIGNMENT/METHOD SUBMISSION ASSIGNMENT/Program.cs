using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.WriteLine("Enter first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number (or press Enter to skip):");
            string secondInput = Console.ReadLine();

            int result;

            if (secondInput == "")
            {
                result = math.DoMath(firstNumber);
            }
            else
            {
                int secondNumber = Convert.ToInt32(secondInput);
                result = math.DoMath(firstNumber, secondNumber);
            }

            Console.WriteLine("Result: " + result);

            Console.ReadLine();
        }
    }
}