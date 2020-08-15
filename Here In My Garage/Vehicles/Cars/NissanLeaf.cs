using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles.Cars
{
    class NissanLeaf : Car
    {
        public bool IsElectric { get; set; }

        public NissanLeaf(bool isElectric) : base("Nissan Leaf", 100, "blue", 5)
        {
            IsElectric = isElectric;
        }

        public void Vroom()
        {
            Console.WriteLine("Car goes vrrrrrr");
        }
    }
}
