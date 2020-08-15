using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles
{
    class Aircraft : Vehicle
    {
        string Name { get; set; }
        public Aircraft(string name, int fuelCapacity, string color, int passengerOccupancy) : base(fuelCapacity, color, passengerOccupancy)
        {
            Name = name;
        }

        public void Flying()
        {
            Console.WriteLine($"I am flying a {Name}");
        }

        public void Landing()
        {
            Console.WriteLine("I am landing");
        }
    }
}
