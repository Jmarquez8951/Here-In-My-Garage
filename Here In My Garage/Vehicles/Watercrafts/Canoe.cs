using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles.Watercrafts
{
    class Canoe : Watercraft
    {
        public Canoe() : base("Canoe", 0, "brown", 2)
        {

        }

        public void Faster()
        {
            Console.WriteLine("Go faster.");
        }
    }
}
