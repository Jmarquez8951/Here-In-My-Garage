using Here_In_My_Garage.Vehicles;
using Here_In_My_Garage.Vehicles.Aircrafts;
using Here_In_My_Garage.Vehicles.Cars;
using Here_In_My_Garage.Vehicles.Watercrafts;
using System;
using System.Collections.Generic;

namespace Here_In_My_Garage
{
    class Program
    {
        static void Main()
        {
            var car1 = new HondaCivic();
            var car2 = new BMW(true);
            var car3 = new NissanLeaf(true);

            var Cars = new List<Car>();
            Cars.Add(car1);
            Cars.Add(car2);
            Cars.Add(car3);

            foreach (var car in Cars)
            {
                car.Driving();
            }

            var plane1 = new WrightFlyer();
            var plane2 = new SupermarineSpitfire();
            var plane3 = new BlériotXI();

            var planes = new List<Aircraft>();
            planes.Add(plane1);
            planes.Add(plane2);
            planes.Add(plane3);

            foreach (var plane in planes)
            {
                plane.Flying();
            }

            var boat1 = new FishingBoat();
            var boat2 = new Canoe();
            var boat3 = new HouseBoat();

            var boats = new List<Watercraft>();
            boats.Add(boat1);
            boats.Add(boat2);
            boats.Add(boat3);

            foreach (var boat in boats)
            {
                boat.Driving();
            }
        }
    }
}
