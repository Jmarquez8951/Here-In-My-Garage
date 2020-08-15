using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles
{
    class Car : Vehicle
    {
        string Name { get; set; } 
        public Car(string name, int fuelCapacity, string color, int passengerOccupancy) : base(fuelCapacity, color, passengerOccupancy)
        {
            Name = name;
        }
        public void Driving()
        {
            Console.WriteLine($"I am driving a {Name}");
        }

        public void Braking()
        {
            Console.WriteLine("I am braking");
        }
    }
}
