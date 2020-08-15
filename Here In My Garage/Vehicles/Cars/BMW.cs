using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles.Cars
{
    class BMW : Car
    {
        public bool IsLuxury { get; set; }
        public BMW(bool isLuxury) : base("BMW", 20, "White", 4)
        {
            IsLuxury = isLuxury;
        }

        public void SelfParking()
        {
            Console.WriteLine("I can park myself");
        }
    }
}
