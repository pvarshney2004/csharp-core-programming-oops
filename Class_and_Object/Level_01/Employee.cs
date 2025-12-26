using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Class_and_Object.Level_01
{
    internal class Employee
    {
        public string EmployeeName;
        public int EmployeeID;
        public int EmployeeSalary;

        // Constructor to initialize employee details
        public Employee(string name, int id, int salary)
        {
            EmployeeName = name;
            EmployeeID = id;
            EmployeeSalary = salary;
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Employee Salary: " + EmployeeSalary);
        }

    }
}
