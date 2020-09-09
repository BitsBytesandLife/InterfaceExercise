using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public Truck(string name, string logo, string model,string truckBed, int year, int payLoadSize, string color)
        {
            Name = name;
            Logo = logo;
            Model = model;
            TruckBed = truckBed;
            Year = year;
            PayLoadSize = 3000;
            Wheels = 4;
            Color = color;        
        }

        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public int Wheels { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public string Color { get; set; }

        public string TruckBed { get; set; }

        public int PayLoadSize { get; set; }

        public void Drive()
        {
            Console.WriteLine($"The {Model} is Drive");
        }

        public void DisplayTruck()
        {
           Console.ForegroundColor = ConsoleColor.DarkGray;
           Console.WriteLine($"Truck Details:\n" +
                                  $"Make: {Name}\n" +
                                  $"Model: {Model}\n" +
                                  $"Year: {Year}\n" +
                                  $"Truck Bed: {TruckBed}\n" +
                                  $"Payload Size {PayLoadSize}\n" +
                                  $"Color: {Color}");
           Console.ResetColor();
           Console.WriteLine();
        }
    }
}
