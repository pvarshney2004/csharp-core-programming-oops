using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Object_Modelling
{
    /*
Problem 2: University with Faculties and Departments (Composition and
Aggregation)
Description: Create a University with multiple Faculty members and Department objects.
Model it so that the University and its Departments are in a composition relationship
(deleting a university deletes all departments), and the Faculty members are in an
aggregation relationship (faculty can exist outside of any specific department).
Tasks:
● Define a University class with Department and Faculty classes.
● Demonstrate how deleting a University also deletes its Departments.
● Show that Faculty members can exist independently of a Department.
Goal: Understand the differences between composition and aggregation in modeling
complex hierarchical relationships
     */
    // University class
    public class University
    {
        public string Name;
        public List<Departmentt> Departmentts; // Composition relationship
        public List<Faculty> Faculties; // Aggregation relationship
        public University(string name)
        {
            Name = name;
            Departmentts = new List<Departmentt>();
            Faculties = new List<Faculty>();
        }
        // Method to add a faculty member ensuring they can exist independently
        public void AddFaculty(Faculty faculty)
        {
            Faculties.Add(faculty);
        }
        // Method to add a department to ensure that when a University is deleted, its departments are also deleted
        public void AddDepartment(string deptName)
        {
            Departmentts.Add(new Departmentt(deptName));
        }
        // method to display university details
        public void DisplayDetails()
        {
            Console.WriteLine($"University: {Name}");
            foreach (var dept in Departmentts)
            {
                Console.WriteLine($"- Department: {dept.Name}");
            }
            foreach (var fac in Faculties)
            {
                Console.WriteLine($"- Faculty: {fac.Name}");
            }
        }
    }

    // Department class
    public class Departmentt
    {
        public string Name;
        public Departmentt(string name)
        {
            Name = name;
        }
    }

    // Faculty class
    public class Faculty
    {
        public string Name;
        public Faculty(string name)
        {
            Name = name;
        }   
    }
}