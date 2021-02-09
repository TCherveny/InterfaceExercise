using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle , ICompany 
    
    { 
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineSize { get ; set; }
        public bool ThirdRowSeat { get; set; }
        public bool RoofRack { get; set; }

        public string Decals { get; set; }
        public string Equipment { get; set; }

        public void Drive()
        {
            Console.WriteLine($"I wish i was driving in my {GetType().Name}");
        }
    }
    //In each of your car, truck, and suv classes

    /*Create 2 members that are specific to each class
     * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     * 
     */
}
