using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles
{
    class Watercraft : Vehicle
    {
        string Name { get; set; }
        public Watercraft(string name, int fuelCapacity, string color, int passengerOccupancy) : base(fuelCapacity, color, passengerOccupancy)
        {
            Name = name;
        }

        public void Driving()
        {
            Console.WriteLine($"I am driving a {Name}.");
        }
    }
}
