using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { FirstName = "Joe", LastName = "Smith", Id = 1 },
                new Employee() { FirstName = "Sarah", LastName = "Jones", Id = 2 },
                new Employee() { FirstName = "Mike", LastName = "Taylor", Id = 3 },
                new Employee() { FirstName = "Joe", LastName = "Brown", Id = 4 },
                new Employee() { FirstName = "Emily", LastName = "White", Id = 5 },
                new Employee() { FirstName = "Chris", LastName = "Green", Id = 6 },
                new Employee() { FirstName = "Anna", LastName = "Hall", Id = 7 },
                new Employee() { FirstName = "David", LastName = "King", Id = 8 },
                new Employee() { FirstName = "Lisa", LastName = "Scott", Id = 9 },
                new Employee() { FirstName = "Mark", LastName = "Allen", Id = 10 }
            };

            // Make a new list for employees named Joe
            List<Employee> joes = new List<Employee>();

            // Find employees with the first name Joe
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            // Print the Joe employees from the foreach loop
            Console.WriteLine("Employees named Joe:");

            foreach (Employee employee in joes)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            // Find employees named Joe using a lambda expression
            List<Employee> joeList = employees.Where(x => x.FirstName == "Joe").ToList();

            // Find employees with an Id greater than 5
            List<Employee> idList = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine("\nEmployees with an Id greater than 5:");

            foreach (Employee employee in idList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            Console.ReadLine();
        }
    }
}