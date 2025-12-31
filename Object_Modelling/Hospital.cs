using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Object_Modelling
{
    /*
Problem 3: Hospital, Doctors, and Patients (Association and Communication)
Description: Model a Hospital where Doctor and Patient objects interact through
consultations. A doctor can see multiple patients, and each patient can consult multiple
doctors.
Tasks:
● Define a Hospital class containing Doctor and Patient classes.
● Create a method Consult() in the Doctor class to show communication, which would
display the consultation between a doctor and a patient.
● Model an association between doctors and patients to show that doctors and
patients can have multiple relationships.
Goal: Practice creating an association with communication between objects by modeling
doctor-patient consultations.
     */
    public class Hospital
    {
        public string Name;
        public List<Doctor> Doctors = new List<Doctor>();
        public List<Patient> Patients = new List<Patient>();
        public Hospital(string name)
        {
            Name = name;
        }
        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
        }

        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

    }
    // Doctor class
    public class Doctor
    {
        public string Name;
        public List<Patient> Patients = new List<Patient>();
        public Doctor(string name)
        {
            Name = name;
        }
        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
            patient.Doctors.Add(this);
        }
        // communication method to show consultation
        public void Consult(Patient patient)
        {
            Console.WriteLine($"Doctor {Name} is consulting with Patient {patient.Name}.");
        }
        // method to show patients
        public void ShowPatients()
        {
            Console.WriteLine($"Doctor {Name} has the following patients:");
            foreach (var patient in Patients)
            {
                Console.WriteLine($"- {patient.Name}");
            }
        }
    }
    // Patient class
    public class Patient
    {
        public string Name;
        public List<Doctor> Doctors = new List<Doctor>();
        public Patient(string name)
        {
            Name = name;
        }
        // method to show consulted doctors
        public void ShowDoctors()
        {
            Console.WriteLine($"Patient {Name} has consulted with the following doctors:");
            foreach (var doctor in Doctors)
            {
                Console.WriteLine($"- Dr. {doctor.Name}");
            }
        }
    }
}

