using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles.Cars
{
    class HondaCivic : Car
    {
        public HondaCivic() : base("Honda Civic", 30, "Red", 5)
        {

        }

        public void CanTalk()
        {
            Console.WriteLine("Is a talking car");
        }
    }
}
