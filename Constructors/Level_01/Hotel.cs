using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming_OOPs.Constructors.Level_01
{
    internal class Hotel
    {
        /*
Hotel Booking System
o Create a HotelBooking class with attributes guestName, roomType, and
nights.
o Use default, parameterized, and copy constructors to initialize bookings.
         */
        public string GuestName;
        public string RoomType;
        public int Nights;
        // Default Constructor
        public Hotel()
        {
            GuestName = "Default Guest";
            RoomType = "Standard";
            Nights = 1;
        }
        // Parameterized Constructor
        public Hotel(string guestName, string roomType, int nights)
        {
            GuestName = guestName;
            RoomType = roomType;
            Nights = nights;
        }
        // Copy Constructor
        public Hotel(Hotel other)
        {
            GuestName = other.GuestName;
            RoomType = other.RoomType;
            Nights = other.Nights;
        }
    }
}
