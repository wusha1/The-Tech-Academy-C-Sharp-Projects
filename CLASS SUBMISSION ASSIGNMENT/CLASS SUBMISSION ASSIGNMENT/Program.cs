using System;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.WriteLine("Enter a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            math.DivideByTwo(userNumber);

            int output;
            math.DivideByTwo(userNumber, out output);
            Console.WriteLine("Output parameter result: " + output);

            math.DivideByTwo(25.5);

            Utility.ShowMessage();

            Console.ReadLine();
        }
    }
}