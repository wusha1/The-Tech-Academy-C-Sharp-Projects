using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> intList = new List<string>();

        intList.Add("Hello");
        intList.Add("Jesse");
        intList.Remove("Jesse");

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        byte[] byteArray = new byte[5000];
    }
}