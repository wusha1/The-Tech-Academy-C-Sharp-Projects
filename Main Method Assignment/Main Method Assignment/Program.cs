using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            int result1 = math.DoMath(10);
            Console.WriteLine("Integer result: " + result1);

            int result2 = math.DoMath(12.5m);
            Console.WriteLine("Decimal result: " + result2);

            int result3 = math.DoMath("20");
            Console.WriteLine("String result: " + result3);

            Console.ReadLine();
        }
    }
}