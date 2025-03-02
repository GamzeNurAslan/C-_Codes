using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Gamze", 18, 90.5);

            Console.WriteLine($"Name: {student1.Name}, Age: {student1.Age}, Grade: {student1.Grade}");
            student1.Name = "Aslan";
            student1.Age = 19;
            student1.Grade = 85.5;

            Console.WriteLine($"Name: {student1.Name}, Age: {student1.Age}, Grade: {student1.Grade}");
        }
    }
}
