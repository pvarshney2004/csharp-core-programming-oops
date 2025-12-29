using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    public class Student
    {
        /*
Problem : University Management System
● Create a Student class with:
o rollNumber (public)
o name (protected)
o CGPA (private)
● Implement methods to:
o Access and modify CGPA using public methods.
o Create a subclass PostgraduateStudent to demonstrate the use of protected
members.
         */
        public int RollNumber;
        protected string Name;
        private double CGPA;

        // parameterized Constructor
        public Student(int rollNumber, string name, double cgpa)
        {
            RollNumber = rollNumber;
            Name = name;
            CGPA = cgpa;
        }
        // public method to get CGPA
        public double GetCGPA()
        {
            return CGPA;
        }
        // public method to modify CGPA
        public void SetCGPA(double cgpa)
        {
            if(cgpa<0 || cgpa>10)
            {
                throw new ArgumentException("CGPA must be between 0 and 10.");
            }
            CGPA = cgpa;
        }
    }

    public class PostgraduateStudent : Student
    {
        public string ResearchTopic;
        // parameterized Constructor using base keyword to call parent constructor(constructor chaining)
        public PostgraduateStudent(int rollNumber, string name, double cgpa, string researchTopic)
            : base(rollNumber, name, cgpa)
        {
            ResearchTopic = researchTopic;
        }
        // method to display student details including protected member
        public void DisplayDetails()
        {
            Console.WriteLine("Roll Number: " + RollNumber);   // public
            Console.WriteLine("Name: " + Name);                // protected
            Console.WriteLine("CGPA: " + GetCGPA());           // private via public method
            Console.WriteLine("Research Area: " + ResearchTopic);
        }
        // method to get Research Topic
        public string GetResearchArea()
        {
            return ResearchTopic;
        }
    }
}
