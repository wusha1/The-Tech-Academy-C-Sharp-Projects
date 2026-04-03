using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Prt. One

        string[] words = { "Apple", "Banana", "Cherry", "Orange" };

        Console.WriteLine("Enter some text to add to each word:");
        string userInput = Console.ReadLine();

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + " " + userInput;
        }

        Console.WriteLine("\nUpdated words:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Prt. Two

        Console.WriteLine("\nPart Two - Fixed loop:");
        int counter = 0;

        while (counter < 5)
        {
            Console.WriteLine("Loop iteration: " + counter);
            counter++;
        }

        // Prt. Three

        Console.WriteLine("\nPart Three - Loop using < operator:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("i = " + i);
        }

        Console.WriteLine("\nPart Three - Loop using <= operator:");
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("i = " + i);
        }

        // Prt. Four

        // 1. List of unique strings
        List<string> fruits = new List<string>()
        {
            "apple",
            "banana",
            "cherry",
            "orange",
            "grape"
        };

        // 2. Ask user to search
        Console.WriteLine("\nPart Four - Search for a fruit:");
        string searchInput = Console.ReadLine().ToLower();

        bool found = false;

        // 3. Loop through list
        for (int i = 0; i < fruits.Count; i++)
        {
            if (fruits[i] == searchInput)
            {
                Console.WriteLine("Found at index: " + i);
                found = true;

                // 5. Stop loop when found
                break;
            }
        }

        // 4. If not found
        if (!found)
        {
            Console.WriteLine("That item is not in the list.");
        }

        // Keeps console open
        Console.WriteLine("\nPress Enter to close the program.");
        Console.ReadLine();
    }
}