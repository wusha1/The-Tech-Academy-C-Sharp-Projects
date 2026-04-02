using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] stringArray = { "Apple", "Banana", "Cherry", "Orange" };

        Console.WriteLine("Select an index for the string array (0-3):");
        int index1 = Convert.ToInt32(Console.ReadLine());

        if (index1 >= 0 && index1 < stringArray.Length)
        {
            Console.WriteLine("You selected: " + stringArray[index1]);
        }
        else
        {
            Console.WriteLine("That index does not exist.");
        }

        int[] intArray = { 10, 20, 30, 40, 50 };

        Console.WriteLine("\nSelect an index for the integer array (0-4):");
        int index2 = Convert.ToInt32(Console.ReadLine());

        if (index2 >= 0 && index2 < intArray.Length)
        {
            Console.WriteLine("You selected: " + intArray[index2]);
        }
        else
        {
            Console.WriteLine("That index does not exist.");
        }

        List<string> stringList = new List<string>() { "Dog", "Cat", "Bird", "Fish" };

        Console.WriteLine("\nSelect an index for the string list (0-3):");
        int index3 = Convert.ToInt32(Console.ReadLine());

        if (index3 >= 0 && index3 < stringList.Count)
        {
            Console.WriteLine("You selected: " + stringList[index3]);
        }
        else
        {
            Console.WriteLine("That index does not exist.");
        }

        Console.ReadLine();
    }
}