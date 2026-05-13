using System;

namespace StructChallenge
{
    // Struct for storing a number amount
    struct Number
    {
        public decimal Amount;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Number object
            Number number = new Number();

            // Give the amount a value
            number.Amount = 25.50m;

            // Show the amount in the console
            Console.WriteLine(number.Amount);

            Console.ReadLine();
        }
    }
}