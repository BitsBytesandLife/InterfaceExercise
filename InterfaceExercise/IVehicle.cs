using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public string Model { get; set; }

        public string Color { get; set; }
        public int Year { get; set; }

        public int Wheels { get; set; } 

        public void Drive();
        
    }
}
