using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.OOPs_Pillars
{
    /*
     1. Employee Management System
Description: Build an employee management system with the following requirements:
● Use an abstract class Employee with fields like employeeId, name, and baseSalary.
● Provide an abstract method CalculateSalary() and a concrete method
DisplayDetails().
● Create two subclasses: FullTimeEmployee and PartTimeEmployee, implementing
CalculateSalary() based on work hours or fixed salary.
● Use encapsulation to restrict direct access to fields and provide properties for access.
● Create an interface IDepartment with methods like AssignDepartment() and
GetDepartmentDetails().
● Ensure polymorphism by processing a list of employees and displaying their details
using the Employee reference.
     */
    // abstract class Employee implementing IDepartment interface
    public abstract class Employee: IDepartment
    {
        private int _EmployeeId;
        public int EmployeeId 
        {
            get
            {
                return _EmployeeId;
            }
            set
            {
                _EmployeeId = value;
            } 
        }
        public string? _Name { get; set; }
        private double _baseSalary;
        public double baseSalary 
        {
            get 
            {
                return _baseSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Salary can't be negative");
                }
                _baseSalary = value;
            } 
        }
        public string? Departmentname;

        public Employee(int employeeId, string name, double baseSalary)
        {
            EmployeeId = employeeId;
            _Name = name;
            this.baseSalary = baseSalary;
        }
        public abstract double CalculateSalary();

        public void AssignDepartment(string deptName)
        {
            this.Departmentname = deptName;
        }

        public string GetDepartmentDetails()
        {
            return $"Employee works in {Departmentname} department.";
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Details: ");
            Console.WriteLine($"ID: {_EmployeeId}, Name: {_Name}, Salary: {CalculateSalary()}");
            Console.WriteLine(GetDepartmentDetails());
        }

    }
    // interface IDepartment
    public interface IDepartment
    {
        void AssignDepartment(string departmentName);
        string GetDepartmentDetails();
    }

    // subclass FullTimeEmployee extending Employee class
    public class FullTimeEmployee : Employee
    {
        private double salaryPerHour = 1000;
        private int extraHours;
        public FullTimeEmployee(int employeeId, string name, double baseSalary, int extraHours)
            : base(employeeId, name, baseSalary)
        {
            this.extraHours = extraHours;
        }
        // overriding CalculateSalary() method with base salary and extra pay hours
        public override double CalculateSalary()
        {
            return baseSalary + (extraHours*salaryPerHour);
        }
    }
    // subclass PartTimeEmployee extending Employee class
    public class PartTimeEmployee : Employee
    {
        public double salaryPerHour = 700;
        private int extraHours;
        public PartTimeEmployee(int employeeId, string name, double baseSalary, int extraHours)
            : base(employeeId, name, baseSalary)
        {
            this.extraHours = extraHours;
        }
        // overriding CalculateSalary() method with base salary and extra pay hours
        public override double CalculateSalary()
        {
            return baseSalary + (extraHours*salaryPerHour);
        }
    }
}
