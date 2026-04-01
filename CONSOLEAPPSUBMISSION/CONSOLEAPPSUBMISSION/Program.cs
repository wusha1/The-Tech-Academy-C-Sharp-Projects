using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WHILE LOOP");
            Console.WriteLine("Guess a number (hint: 5)");

            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 5;

            while (!isGuessed)
            {
                Console.WriteLine("Wrong guess. Try again.");
                Console.WriteLine("Guess a number:");
                number = Convert.ToInt32(Console.ReadLine());
                isGuessed = number == 5;
            }

            Console.WriteLine("Correct! You guessed 5.");

            Console.WriteLine("\nDO-WHILE LOOP");
            Console.WriteLine("Guess a number (hint: 10)");

            int number2 = Convert.ToInt32(Console.ReadLine());
            bool isGuessed2 = number2 == 10;

            do
            {
                if (!isGuessed2)
                {
                    Console.WriteLine("Wrong guess. Try again.");
                    Console.WriteLine("Guess a number:");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    isGuessed2 = number2 == 10;
                }
            }
            while (!isGuessed2);

            Console.WriteLine("Correct! You guessed 10.");

            Console.ReadLine();
        }
    }
}