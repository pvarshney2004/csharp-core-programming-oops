using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    internal class Person
    {
        /*
Person Class (Copy Constructor)
o Create a Person class with a copy constructor that clones another person's
attributes.
         */
        public string Name;
        public int Age;
        // Parameterized Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Copy Constructor
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
        }
    }
}
