using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Keywords.Level_01
{
    internal class Vehicle
    {
        /*
Sample Program 6: Vehicle Registration System
Create a Vehicle class with the following features:
● static:
o A static variable RegistrationFee common for all vehicles.
o A static method UpdateRegistrationFee() to modify the fee.
● this:
o Use this to initialize OwnerName, VehicleType, and RegistrationNumber in the
constructor.
● readonly:
o Use a readonly variable RegistrationNumber to uniquely identify each vehicle.
● is operator:
o Check if an object belongs to the Vehicle class before displaying its
registration details.
         */

        // ----------static---------- 
        public static int RegistrationFee = 1000;
        public static void UpdateRegistrationFee(int newFee)
        {
            RegistrationFee = newFee;
        }

        // ----------instance----------
        public string OwnerName;
        public string VehicleType;

        // ----------readonly---------- 
        public readonly int RegistrationNumber;

        // constructor
        public Vehicle(string name, string type, int number)
        {
            this.OwnerName = name;
            this.VehicleType = type;
            this.RegistrationNumber = number;
        }

        // method to display vehicle details
        public void DisplayDetails()
        {
            Console.WriteLine("Registration Number: " + RegistrationNumber);
            Console.WriteLine("Owner Name: " + OwnerName);
            Console.WriteLine("Vehicle Type: " + VehicleType);
        }
    }
}
