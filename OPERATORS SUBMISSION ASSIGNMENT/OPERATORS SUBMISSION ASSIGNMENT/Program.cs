using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // First employee
            Employee employee1 = new Employee();
            employee1.FirstName = "Jesse";
            employee1.LastName = "Smith";
            employee1.Id = 1;

            // Second employee
            Employee employee2 = new Employee();
            employee2.FirstName = "Sarah";
            employee2.LastName = "Jones";
            employee2.Id = 1;

            // Compare employee Ids
            Console.WriteLine(employee1 == employee2);

            Console.ReadLine();
        }
    }
}