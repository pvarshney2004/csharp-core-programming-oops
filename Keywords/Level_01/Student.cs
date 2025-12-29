using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Keywords.Level_01
{
    internal class Student
    {
        /*
Sample Program 5: University Student Management
Create a Student class to manage student data with the following features:
● static:
o A static variable UniversityName shared across all students.
o A static method DisplayTotalStudents() to show the number of students
enrolled.
● this:
o Use this in the constructor to initialize Name, RollNumber, and Grade.
● readonly:
o Use a readonly variable RollNumber for each student that cannot be changed.
● is operator:
o Check if a given object is an instance of the Student class before performing
operations like displaying or updating grades.
         */
        // ----------static---------- 
        public static string UniversityName = "GLA University";
        private static int totalStudents;
        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total students: " + totalStudents);
        }

        // ----------instance----------
        public string Name;
        public char Grade;

        // ----------readonly---------- 
        public readonly int RollNumber;

        // constructor
        public Student(string name, int roll, char grade)
        {
            this.Name = name;
            this.RollNumber = roll;
            this.Grade = grade;
            totalStudents++;
        }

        // method to student book details
        public void DisplayDetails()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Grade: " + Grade);
        }
    }
}
