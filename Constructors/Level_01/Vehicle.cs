using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    internal class Vehicle
    {
        /*
Problem : Vehicle Registration
● Create a Vehicle class to manage vehicle details:
o Instance Variables: ownerName, vehicleType.
o Class Variable: registrationFee (fixed for all vehicles).
● Implement the following methods:
o An instance method DisplayVehicleDetails() to display owner and vehicle
details.
o A class method UpdateRegistrationFee() to change the registration fee.
         */
        public string OwnerName;
        public string VehicleType;
        public static double RegistrationFee = 1000.0; // fixed fee for all vehicles
        // parameterized Constructor
        public Vehicle(string ownerName, string vehicleType)
        {
            OwnerName = ownerName;
            VehicleType = vehicleType;
        }
        // instance method to display vehicle details
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Owner Name: {OwnerName}, Vehicle Type: {VehicleType}, Registration Fee: {RegistrationFee}");
        }
        // class method to update registration fee
        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
        }
    }
}
