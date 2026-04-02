using System;

class Program
{
    static void Main()
    {
        // 1. One-dimensional array of strings
        string[] words = { "Apple", "Banana", "Cherry", "Orange" };

        // 2. Ask the user for input
        Console.WriteLine("Enter some text to add to each word:");
        string userInput = Console.ReadLine();

        // 3. Loop through array and add user input
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + " " + userInput;
        }

        // 4. Loop to print each string on a new line
        Console.WriteLine("\nUpdated words:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Keeps console open (important for testing)
        Console.ReadLine();
    }
}