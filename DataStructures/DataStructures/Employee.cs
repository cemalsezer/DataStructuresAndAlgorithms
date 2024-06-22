using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Employee
    {
        public Employee(string firstName, string lastName, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public override string? ToString()
        {
            return $"{FirstName,-5} {LastName,-5} {Salary,-5}";
        }
    }
}
