using System;
using System.Collections.Generic;
using System.Text;

namespace Here_In_My_Garage.Vehicles.Aircrafts
{
    class SupermarineSpitfire : Aircraft
    {
        public SupermarineSpitfire() : base("Supermarine Spitfire", 20, "Grey", 1)
        {

        }

        public void Shoot()
        {
            Console.WriteLine("Pew pew pew pew");
        }
    }
}
