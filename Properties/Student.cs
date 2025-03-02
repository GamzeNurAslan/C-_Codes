using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Student
    {
        private string name;
        private int age;
        private double grade;

        #region Properties with backing fields

        //Property for student's name
        /*public string Name
        {
            get => name;
            set => name = !string.IsNullOrEmpty(value) ? value : name;
        }*/

        public string Name
        {
            get { return name; }
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }

            }
        }
        //Property for student's age
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        //Property for student's grade
        public double Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
            }
        }

    }
}
