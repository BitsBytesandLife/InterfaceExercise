using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public int Wheels { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public void Drive()
        {
            Console.WriteLine($"The {Model} is in drive.");
        }
    }
}
