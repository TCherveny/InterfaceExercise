using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car Neon = new Car { Year = "2003", Make = "dodge", Model = "Neon", EngineSize = "5HP Briggs", Coupe = false, Sedan = true, Decals = "Company Name", Equipment = "NA",  };

            Truck F700 = new Truck { Year = "1999", Make = "Ford", Model = "F700", EngineSize = "460CI", CrewCab = true, StandardCab = false, Decals = "company Information", Equipment = "Retrieval Winch", };
            SUV Excursion = new SUV { Year = "2020", Make = "Ford", Model = "Excursion", EngineSize = "7.77 litre", RoofRack = true, ThirdRowSeat = true, Decals = "PRISONER TRANSPORT", Equipment = "Riot Gear", };

            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(Neon);
            vehicles.Add(F700);
            vehicles.Add(Excursion);

            foreach (IVehicle vehicle in vehicles )
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Engin Size: {vehicle.EngineSize}");
                vehicle.Drive();
                Console.WriteLine();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            List<ICompany> vehicle2 = new List<ICompany>();
            vehicle2.Add(Neon);
            vehicle2.Add(F700);
            vehicle2.Add(Excursion);

            foreach (ICompany company in vehicle2)
            {
                Console.WriteLine($"Decals: {company.Decals}");
                Console.WriteLine($"Equipment: {company.Equipment}");
                Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }












            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE  Create 2 Interfaces called IVehicle & ICompany

            //DONE  Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE Create 4 members that Car, Truck, & SUV all have in common.
                    * Example: All vehicles have a number of wheels... for now..
                    */


            //In ICompany

            /*DONE   Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*DONE Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
