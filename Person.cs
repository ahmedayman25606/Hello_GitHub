using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Person
    {
        public string Name { get; set; }

        public string Department { get; set; }
        public int Age { get; set; }
        public Person(string name, string department, int age)
        {
            Name = name;
            Department = department;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Department: {Department}, Age: {Age}";
        }
    }
}
