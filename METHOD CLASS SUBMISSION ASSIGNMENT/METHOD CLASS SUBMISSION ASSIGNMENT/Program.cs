using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            // Normal call
            math.DoMath(5, 10);

            // Named parameters
            math.DoMath(num1: 7, num2: 20);

            Console.ReadLine();
        }
    }
}