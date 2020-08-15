using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles.Watercrafts
{
    class HouseBoat : Watercraft
    {
        public HouseBoat() : base("House boat", 0, "white", 10)
        {

        }

        public void MyHouse()
        {
            Console.WriteLine("I live here");
        }
    }
}
