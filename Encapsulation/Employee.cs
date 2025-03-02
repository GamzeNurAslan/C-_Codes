using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Employee
    {
        //Fields
        private string name;
        private int employeeID;
        private double salary;

        //Constructor
        public Employee(string name, int employeeID, double salary)
        {
            this.name = name;
            this.employeeID = employeeID;
            this.salary = salary;
        }

        //Properties to access and modify prrvate fields

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int EmployeeId
        {
            get { return employeeID; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    Console.WriteLine("Salary cannot be negative.");
            }
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: ${Salary}");
        }
    }
}
