using System;

class Program
{
    static void Main()
    {
        // Prt. One

        // 1. One-dimensional array of strings
        string[] words = { "Apple", "Banana", "Cherry", "Orange" };

        // 2. Ask the user to input some text
        Console.WriteLine("Enter some text to add to each word:");
        string userInput = Console.ReadLine();

        // 3. Loop through each string and add the user's text
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + " " + userInput;
        }

        // 4. Print each string on a separate line
        Console.WriteLine("\nUpdated words:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Prt. Two

        // Fixed version of the infinite loop
        Console.WriteLine("\nPart Two - Fixed loop:");
        int counter = 0;

        while (counter < 5)
        {
            Console.WriteLine("Loop iteration: " + counter);
            counter++;
        }

        // Prt. Three

        // Loop using <
        Console.WriteLine("\nPart Three - Loop using < operator:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("i = " + i);
        }

        // Loop using <=
        Console.WriteLine("\nPart Three - Loop using <= operator:");
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("i = " + i);
        }

        // Keeps console open
        Console.WriteLine("\nPress Enter to close the program.");
        Console.ReadLine();
    }
}