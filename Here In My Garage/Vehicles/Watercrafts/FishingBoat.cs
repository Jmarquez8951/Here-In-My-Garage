using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles.Watercrafts
{
    class FishingBoat : Watercraft
    {
        public FishingBoat() : base("Bubba Gump", 30, "White", 10)
        {

        }

        public void Fish()
        {
            Console.WriteLine("You try to fish.");
        }
    }
}
