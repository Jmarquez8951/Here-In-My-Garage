using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles.Aircrafts
{
    class WrightFlyer : Aircraft
    {
        public WrightFlyer() : base("Wright Flyer", 0, "white", 1)
        {

        }

        public void Fact()
        {
            Console.WriteLine("I was the first to fly.");
        }
    }
}
