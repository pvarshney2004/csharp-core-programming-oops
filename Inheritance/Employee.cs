using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Inheritance
{
    /*
     2. Employee Management System
Description:
Create an Employee hierarchy for different employee types such as Manager, Developer, and
Intern.
Tasks:
1. Define a base class Employee:
o Add three attributes: Name (string), Id (integer), and Salary (double).
o Add a method DisplayDetails() to display the details of an employee.
2. Define subclasses Manager, Developer, and Intern:
o Manager: Add an additional attribute TeamSize (integer).
o Developer: Add an additional attribute ProgrammingLanguage (string).
o Intern: Add an additional attribute InternshipDuration (string).
3. Goal:
o Practice inheritance by creating subclasses with specific attributes and
overriding superclass methods (e.g., DisplayDetails()) to display details specific
to each type of employee
     */
    // Base class(Employee)
    public class Employee
    {
        public int ID;
        public string Name;
        public double Salary;

        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }
        // virtal method that can be overridden in subclasses
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Salary: {Salary}");
        }
    }
    // Subclass(Manager)
    public class Manager : Employee
    {
        public int TeamSize;
        public Manager(int id, string name, double salary, int TeamSize)
            : base(id, name, salary)
        {
            this.TeamSize = TeamSize;
        }
        // overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Teamsize: {TeamSize}");
        }
    }
    // Subclass(Developer)
    public class Developer : Employee
    {
        public string ProgrammingLanguage;
        public Developer(int id, string name, double salary, string programmingLanguage)
            : base(id, name, salary)
        {
            this.ProgrammingLanguage = programmingLanguage;
        }
        // overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"ProgrammingLanguage: {ProgrammingLanguage}");
        }
    }

    // Subclass(Intern)
    public class Intern : Employee
    {
        public string InternshipDuration;
        public Intern(int id, string name, double salary, string internshipDuration): base(id, name, salary) 
        {
            this.InternshipDuration = internshipDuration;
        }
        // overriding the DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"InternshipDuration: {InternshipDuration}");
        }
    }
}
