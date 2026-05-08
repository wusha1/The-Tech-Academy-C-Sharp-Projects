using System;
using System.Collections.Generic;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee with strings
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>()
            {
                "Shoes",
                "Hat",
                "Phone"
            };

            // Employee with integers
            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>()
            {
                1,
                2,
                3
            };

            // Print string list
            foreach (string item in employee1.Things)
            {
                Console.WriteLine(item);
            }

            // Print integer list
            foreach (int item in employee2.Things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}