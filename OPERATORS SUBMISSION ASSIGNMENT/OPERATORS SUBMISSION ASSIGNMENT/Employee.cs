using System;

namespace OperatorsAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Compare employees by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }

        // Check if employee Ids are different
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }
    }
}