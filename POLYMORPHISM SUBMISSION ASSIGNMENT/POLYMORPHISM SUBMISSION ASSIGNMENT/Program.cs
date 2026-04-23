using System;

namespace PolymorphismAssignment
{
    public interface IQuittable
    {
        void Quit();
    }

    public class Employee : IQuittable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Quit()
        {
            Console.WriteLine("Employee has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee();

            employee.Quit();

            Console.ReadLine();
        }
    }
}