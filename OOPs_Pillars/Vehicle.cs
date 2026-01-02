using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.OOPs_Pillars
{
    /*
     3. Vehicle Rental System
Description: Design a system to manage vehicle rentals:
● Define an abstract class Vehicle with fields like vehicleNumber, type, and rentalRate.
● Add an abstract method CalculateRentalCost(int days).
● Create subclasses Car, Bike, and Truck with specific implementations of
CalculateRentalCost().
● Use an interface IInsurable with methods CalculateInsurance() and
GetInsuranceDetails().
● Apply encapsulation to restrict access to sensitive details like insurance policy
numbers.
● Demonstrate polymorphism by iterating over a list of vehicles and calculating rental and
insurance costs for each.
     */

    // Interface for insurable vehicles
    public interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }
    // Abstract class for vehicles
    public abstract class Vehicle
    {
        public string? VehicleNumber;
        public string? Type;
        public double RentalRate;

        public Vehicle(string vehicleNumber, string type, double rentalRate)
        {
            VehicleNumber = vehicleNumber;
            Type = type;
            RentalRate = rentalRate;
        }
        public abstract double CalculateRentalCost(int days);
    }

    //subclass Car class that extends Vehicle and implements IInsurable
     
    public class Car : Vehicle, IInsurable
    {
        private string? insurancePolicyNumber;
        public Car(string vehicleNumber, double rentalRate, string insurancePolicyNumber)
            : base(vehicleNumber, "car", rentalRate)
        {
            this.insurancePolicyNumber = insurancePolicyNumber;
        }
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }
        // calculating insurance cost for car by rental rate
        public double CalculateInsurance()
        {
            return 0.05 * RentalRate;
        }
        public string GetInsuranceDetails()
        {
            return $"Car Insurance with Insurance Policy Number: {insurancePolicyNumber}";
        }
    }
    //subclass Bike class that extends Vehicle and implements IInsurable

    public class Bike : Vehicle, IInsurable
    {
        private string? insurancePolicyNumber;
        public Bike(string vehicleNumber, double rentalRate, string insurancePolicyNumber)
            : base(vehicleNumber, "bike", rentalRate)
        {
            this.insurancePolicyNumber = insurancePolicyNumber;
        }
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }
        public double CalculateInsurance()
        {
            return 0.03 * RentalRate;
        }
        public string GetInsuranceDetails()
        {
            return $"Bike Insurance with Insurance Policy Number: {insurancePolicyNumber}";
        }
    }
    //subclass truck class that extends Vehicle and implements IInsurable

    public class Truck : Vehicle, IInsurable
    {
        private string? insurancePolicyNumber;
        public Truck(string vehicleNumber, double rentalRate, string insurancePolicyNumber)
            : base(vehicleNumber, "truck", rentalRate)
        {
            this.insurancePolicyNumber = insurancePolicyNumber;
        }
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }
        public double CalculateInsurance()
        {
            return 0.07 * RentalRate;
        }
        public string GetInsuranceDetails()
        {
            return $"Truck Insurance with Insurance Policy Number: {insurancePolicyNumber}";
        }
    }
}
