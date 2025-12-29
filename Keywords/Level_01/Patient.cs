using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Keywords.Level_01
{
    internal class Patient
    {
        /*
Sample Program 7: Hospital Management System
Create a Patient class with the following features:
● static:
o A static variable HospitalName shared among all patients.
o A static method GetTotalPatients() to count the total patients admitted.
● this:
o Use this to initialize Name, Age, and Ailment in the constructor.
● readonly:
o Use a readonly variable PatientID to uniquely identify each patient.
● is operator:
o Check if an object is an instance of the Patient class before displaying its
details.
         */
        // ----------static---------- 
        public static string HospitalName = "XYZ Medicity";
        private static int totalPatients = 0;
        public static void DisplayTotalPatients()
        {
            Console.WriteLine("Total Patients Count: " + totalPatients);
        }

        // ----------instance----------
        public string PatientName;
        public int age;
        public string ailment;

        // ----------readonly---------- 
        public readonly int PatientID;

        // constructor
        public Patient(int id, string PatientName, string ailment, int age)
        {
            this.PatientID = id;
            this.PatientName = PatientName;
            this.ailment = ailment;
            this.age = age;
        }

        // method to display patient details
        public void DisplayDetails()
        {
            Console.WriteLine("Hospital Name: " + HospitalName);
            Console.WriteLine("Patient Id: " + PatientID);
            Console.WriteLine("Patient Name: " + PatientName);
            Console.WriteLine("Ailment: " + ailment);
        }
    }
}
