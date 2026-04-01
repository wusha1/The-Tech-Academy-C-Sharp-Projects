using System;
using System.Text;

namespace StringsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string first = "Hello";
            string second = " Victor";
            string third = "!";

            string combined = first + second + third;
            Console.WriteLine("Concatenated string:");
            Console.WriteLine(combined);
        
            string lower = "this is my string";
            string upper = lower.ToUpper();

            Console.WriteLine("\nUppercase string:");
            Console.WriteLine(upper);

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Victor. ");
            sb.Append("I am learning C# programming. ");
            sb.Append("This is my StringBuilder paragraph. ");
            sb.Append("I will keep improving every day.");

            Console.WriteLine("\nStringBuilder paragraph:");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}