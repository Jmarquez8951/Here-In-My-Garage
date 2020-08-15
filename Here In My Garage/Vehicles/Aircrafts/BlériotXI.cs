using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles.Aircrafts
{
    class BlériotXI : Aircraft
    {
        public BlériotXI() : base("Blériot XI", 0, "brown", 1)
        {
            
        }

        public void English()
        {
            Console.WriteLine("First plane to cross the english channel.");
        }
    }
}
