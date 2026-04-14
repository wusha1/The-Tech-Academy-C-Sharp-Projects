using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.firstName = "Sample";
            emp.lastName = "Student";

            emp.SayName();

            Console.ReadLine();
        }
    }
}