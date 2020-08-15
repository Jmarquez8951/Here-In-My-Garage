using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles
{
    abstract class Vehicle
    {
        public int FuelCapacity { get; }
        public string Color { get; }
        public int PassengerOccupancy { get; }

        protected Vehicle(int fuelCapacity, string color, int passengerOccupancy)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            PassengerOccupancy = passengerOccupancy;
        }

        public void Refueling()
        {
            Console.WriteLine("Refueled");
        }
    }
}
