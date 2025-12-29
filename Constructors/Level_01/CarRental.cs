using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    internal class CarRental
    {
        /*
Car Rental System
o Create a CarRental class with attributes customerName, carModel, and
rentalDays.
o Add constructors to initialize the rental details and calculate total cost.
         */
        public string CustomerName;
        public string CarModel;
        public int RentalDays;
        // assuming a fixed rate per day for simplicity
        private double RatePerDay = 50.0;

        // parameterized Constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            CustomerName = customerName;
            CarModel = carModel;
            RentalDays = rentalDays;
        }
        // method to calculate total cost
        public double CalculateTotalCost()
        {
            return RentalDays * RatePerDay;
        }
    }
}
