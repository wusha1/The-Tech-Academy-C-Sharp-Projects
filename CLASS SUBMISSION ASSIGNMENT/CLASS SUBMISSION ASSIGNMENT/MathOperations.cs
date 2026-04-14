using System;

namespace ClassAssignment
{
    public class MathOperations
    {
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine("Result: " + result);
        }

        public void DivideByTwo(int number, out int result)
        {
            result = number / 2;
        }

        public void DivideByTwo(double number)
        {
            double result = number / 2;
            Console.WriteLine("Double result: " + result);
        }
    }
}