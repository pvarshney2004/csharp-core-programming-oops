using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Keywords.Level_01
{
    internal class Employee
    {
        /*
Sample Program 3: Employee Management System
Design an Employee class with the following features:
● static:
o A static variable CompanyName shared by all employees.
o A static method DisplayTotalEmployees() to show the total number of
employees.
● this:
o Use this to initialize Name, Id, and Designation in the constructor.
● readonly:
o Use a readonly variable Id for the employee ID, which cannot be modified
after assignment.
● is operator:
o Check if a given object is an instance of the Employee class before printing
the employee details.
         */
        // ----------static---------- 
        public static string CompanyName = "ABC Private Limited";
        private static int totalEmployees = 0;
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employee Count: " + totalEmployees);
        }

        // ----------instance----------
        public string EmployeeName;
        public string Designation;

        // ----------readonly---------- 
        public readonly int EmployeeID;

        // constructor
        public Employee(string EmployeeName, string Designation, int ID)
        {
            this.EmployeeName = EmployeeName;
            this.Designation = Designation;
            this.EmployeeID = ID;
        }

        // method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine("Company Name: " + CompanyName);
            Console.WriteLine("Employee Id: " + EmployeeID);
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Employee Designation: " + Designation);
        }
    }
}
