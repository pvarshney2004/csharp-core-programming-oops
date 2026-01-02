using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.OOPs_Pillars
{
    /*
     7. Hospital Patient Management
Description: Design a system to manage patients in a hospital.
● Abstract Class:
o Create an abstract class Patient with fields: patientId, name, and age.
o Add an abstract method CalculateBill().
o Implement a concrete method GetPatientDetails().
● Subclasses:
o Extend Patient into InPatient and OutPatient.
o Implement CalculateBill() differently for each subclass.
● Interface:
o Implement an interface IMedicalRecord.
o Define methods AddRecord() and ViewRecords().
● Encapsulation:
o Protect sensitive patient data like diagnosis and medical history.
● Polymorphism:
o Use a Patient reference to handle different patient types dynamically.
o Display billing details based on polymorphic behavior.
     */
    // abstract class Patient
    public abstract class Patient
    {
        public int Id { get; set; }
        public string Name;
        public int Age;
        public Patient(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public abstract double CalculateBill();
        public void GetPatientDetails()
        {
            Console.WriteLine("Patient details: ");
            Console.WriteLine($"Patient ID: {Id} | Patient Name: {Name} | Age: {Age}");
            Console.WriteLine($"Bill Amount of patient: {CalculateBill()}");
        }
    }

    // interface 
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    // subclass InPatient that inherits Patient class and implements IMedicalRecord interface
    class InPatient : Patient, IMedicalRecord
    {
        private string record;
        public InPatient(int id, string name, int age) : base(id, name, age) { }
        public override double CalculateBill()
        {
            return 5670;
        }
        public void AddRecord(string record)
        {
            this.record = record;
        }
        public void ViewRecords()
        {
            Console.WriteLine(record);
        }
    }
    // subclass OutPatient that inherits Patient class

    class OutPatient : Patient
    {
        public OutPatient(int id, string name, int age) : base(id, name, age) { }
        public override double CalculateBill()
        {
            return 700;
        }
    }
}
