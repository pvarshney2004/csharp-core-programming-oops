using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Object_Modelling
{
    /*
Problem 1: School and Students with Courses (Association and Aggregation)
Description: Model a School with multiple Student objects, where each student can enroll in
multiple courses, and each course can have multiple students.
Tasks:
● Define School, Student, and Course classes.
● Model an association between Student and Course to show that students can enroll
in multiple courses.
● Model an aggregation relationship between School and Student.
● Demonstrate how a student can view the courses they are enrolled in and how a
course can show its enrolled students.
Goal: Practice association by modeling many-to-many relationships between students and
courses.
     */
    public class School
    {
        public string? SchoolName;
        public List<Student> Students;
        public School(string schoolName)
        {
            SchoolName = schoolName;
            Students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        // method to show all students in the school

        public void ShowStudents()
        {
            Console.WriteLine($"Students in {SchoolName}:");
            foreach (var student in Students)
            {
                Console.WriteLine($"- {student.StudentName}");
            }
        }
    }
    public class Student
    {
        public string? StudentName;
        public List<Course> EnrolledCourses; // Association with Course

        public Student(string studentName)
        {
            StudentName = studentName;
            EnrolledCourses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            EnrolledCourses.Add(course);
            course.EnrolledStudents.Add(this); // Establishing the association
        }

        // method to view enrolled courses
        public void ViewEnrolledCourses()
        {
            Console.WriteLine($"Courses enrolled by {StudentName}:");
            foreach (var course in EnrolledCourses)
            {
                Console.WriteLine($"- {course.CourseName}");
            }
        }

    }
    public class Course
    {
        public string? CourseName;
        public List<Student> EnrolledStudents;
        
        public Course(string courseName)
        {
            CourseName = courseName;
            EnrolledStudents = new List<Student>();
        }

        // method to show enrolled students
        public void ShowEnrolledStudents()
        {
            Console.WriteLine($"Students enrolled in {CourseName}:");
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine($"- {student.StudentName}");
            }
        }
    }
}
