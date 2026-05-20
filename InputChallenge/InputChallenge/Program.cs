using System;
using System.IO;

namespace InputChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // This asks users for a number\
            Console.WriteLine("Please enter a number:");
            string userNumber = Console.ReadLine();

            // Saves number to text file
            File.WriteAllText("log.txt", userNumber);

            // Read the file and prints to user
            string fileText = File.ReadAllText("log.txt");

            Console.WriteLine("The number in the text file is: " + fileText);

            Console.ReadLine();
        }
    }
}