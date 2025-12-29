using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    internal class OnlineCourse
    {
        /*
Problem : Online Course Management
● Design a Course class with:
o Instance Variables: courseName, duration, fee.
o Class Variable: instituteName (common for all courses).
● Implement the following methods:
o An instance method DisplayCourseDetails() to display course details.
o A class method UpdateInstituteName() to modify the institute name for all
courses.
         */
        public string CourseName;
        public int Duration; // let the duration of course in hours
        public double Fee;
        public static string InstituteName = "Global Online Academy";
        // parameterized Constructor
        public OnlineCourse(string courseName, int duration, double fee)
        {
            CourseName = courseName;
            Duration = duration;
            Fee = fee;
        }
        // instance method to display course details
        public void DisplayCourseDetails()
        {
            Console.WriteLine($"Course Name: {CourseName}, Duration: {Duration} hours, Fee: {Fee}, Institute: {InstituteName}");
        }
        // class method to update institute name
        public static void UpdateInstituteName(string newInstituteName)
        {
            InstituteName = newInstituteName;
        }
    }
}
