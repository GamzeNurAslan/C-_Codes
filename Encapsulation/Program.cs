using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an employee object
            Employee employee1 = new Employee("Gamze Nur Aslan", 1001, 50000);

            employee1.DisplayEmployeeInfo();
        }
    }
}
