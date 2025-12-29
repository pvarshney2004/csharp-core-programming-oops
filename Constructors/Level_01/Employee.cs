using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    public class Employee
    {
        /*
Problem : Employee Records
● Develop an Employee class with:
o employeeID (public)
o department (protected)
o salary (private)
● Implement methods to:
o Modify salary using a public method.
o Create a subclass Manager to access employeeID and department
         */
        public int EmployeeID;
        protected string Department;
        private double Salary;

        // constructor
        public Employee(int id, string dept, double sal)
        {
            EmployeeID = id;
            Department = dept;
            Salary = sal;
        }

        // Public method to modify salary
        public void ModifySalary(double newSalary)
        {
            Salary = newSalary;
        }
        // public method to get salary
        public double GetSalary()
        {
            return Salary;
        }
    }

    // subclass manager
    public class Manager : Employee
    {
        public string role;

        public Manager(int employeeID, string department, double salary, string role)
            : base(employeeID, department, salary)
        {
            this.role = role;
        }
        public void DisplayManagerInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}, Department: {Department}, manager Role: {role}, salary: {GetSalary()}");
        }
    }
}
