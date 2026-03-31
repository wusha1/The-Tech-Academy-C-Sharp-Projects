using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pick a number: 1, 4, or 8");
        int number = Convert.ToInt32(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("Nice! You picked 1.");
                break;

            case 4:
                Console.WriteLine("Great choice! You picked 4.");
                break;

            case 8:
                Console.WriteLine("Awesome! You picked 8.");
                break;

            default:
                Console.WriteLine("Invalid choice. Please pick 1, 4, or 8.");
                break;
        }

        Console.ReadLine();
    }
}