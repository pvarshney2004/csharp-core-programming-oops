using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Object_Modelling
{
    /*
Problem 3: Company and Departments (Composition)
Description: A Company has several Department objects, and each department contains
Employee objects. Model this using composition, where deleting a Company should also
delete all departments and employees.
Tasks:
● Define a Company class that contains multiple Department objects.
● Define an Employee class within each Department.
● Show the composition relationship by ensuring that when a Company object is
deleted, all associated Department and Employee objects are also removed.
Goal: Understand composition by implementing a relationship where Department and
Employee objects cannot exist without a Company
     */
    // Company class
    public class Company
    {
        public string CompanyName;
        public List<Department> Departments;   // Collection of Department objects  
        public Company(string name) 
        {
            CompanyName = name;
            Departments = new List<Department>();
        }
        public void AddDepartment(string deptName)
        {
            Departments.Add(new Department(deptName)); // Adding new Department object to the collection ensuring composition 
        }
        // method to display company details 
        public void DisplayCompanyDetails()
        {
            Console.WriteLine("Company Name: "+CompanyName);
            foreach(var dept in Departments)
            {
                dept.DisplayEmployess();
            }
        }
        
    }
    // Department class
    public class Department
    {
        public string DepartmentName;
        private List<Employee> Employees = new List<Employee>(); // Collection of Employee objects
        public Department(string name)
        {
            this.DepartmentName = name;
            Employees.Add(new Employee("Employee-1"));
            Employees.Add(new Employee("Employee-2"));
        }
        // method to display department employees
        public void DisplayEmployess()
        {
            Console.WriteLine("Department Name: " + DepartmentName);
            foreach(var emp in  Employees)
            {
                Console.WriteLine(emp.Name);
            }
        }
    }
    // Employee class
    public class Employee
    {
        public string Name;
        public Employee(string name) 
        {
            this.Name = name;
        }
    }
}
