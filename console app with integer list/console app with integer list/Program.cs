using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

        Console.WriteLine("Enter a number to divide each number in the list by:");

        try
        {
            int userNumber = Convert.ToInt32(Console.ReadLine());

            foreach (int number in numbers)
            {
                Console.WriteLine(number / userNumber);
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("The program has emerged from the try/catch block and continued execution.");
        Console.ReadLine();
    }
}