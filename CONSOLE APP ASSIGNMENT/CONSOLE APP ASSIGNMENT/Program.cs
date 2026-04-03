using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Part 1
        string[] words = { "Apple", "Banana", "Cherry", "Orange" };

        Console.WriteLine("Enter some text:");
        string userInput = Console.ReadLine();

        for (int i = 0; i < words.Length; i++)
        {
            words[i] += " " + userInput;
        }

        Console.WriteLine("\nUpdated words:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Part 2
        Console.WriteLine("\nPart 2:");
        int counter = 0;

        while (counter < 5)
        {
            Console.WriteLine("Loop: " + counter);
            counter++;
        }

        // Part 3
        Console.WriteLine("\nPart 3 (<):");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nPart 3 (<=):");
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        // Part 4
        List<string> fruits = new List<string>()
        {
            "apple", "banana", "cherry", "orange", "grape"
        };

        Console.WriteLine("\nPart 4 - Search:");
        string searchInput = Console.ReadLine().ToLower();

        bool found = false;

        for (int i = 0; i < fruits.Count; i++)
        {
            if (fruits[i] == searchInput)
            {
                Console.WriteLine("Index: " + i);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Not found.");
        }

        // Part 5
        List<string> items = new List<string>()
        {
            "apple", "banana", "cherry", "apple", "orange", "banana"
        };

        Console.WriteLine("\nPart 5 - Search:");
        string searchItem = Console.ReadLine().ToLower();

        bool foundItem = false;

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == searchItem)
            {
                Console.WriteLine("Index: " + i);
                foundItem = true;
            }
        }

        if (!foundItem)
        {
            Console.WriteLine("Not found.");
        }

        // Part 6
        List<string> duplicateList = new List<string>()
        {
            "apple", "banana", "cherry", "apple", "orange", "banana"
        };

        Console.WriteLine("\nPart 6 - Duplicate check:");

        List<string> seen = new List<string>();

        foreach (string item in duplicateList)
        {
            if (seen.Contains(item))
            {
                Console.WriteLine(item + " - already appeared");
            }
            else
            {
                Console.WriteLine(item + " - new item");
                seen.Add(item);
            }
        }

        Console.WriteLine("\nPress Enter to close.");
        Console.ReadLine();
    }
}