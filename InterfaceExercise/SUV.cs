using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {

        public SUV(string name, string logo, string model, bool hasDVDPlayer, int year, string color)
        {
            Name = name;
            Logo = logo;
            Model = model;
            HasDVDPlayer = hasDVDPlayer;
            Year = year;
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

        public bool HasDVDPlayer { get; set; }

        public void Drive()
        {
            Console.WriteLine($"The {Model} is Drive");
        }

        public void DisplaySUV()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"SUV Details: \n" +
                              $"Make: {Name} \n" +
                              $"Model: {Model}\n" +
                              $"Year: {Year} \n"  +
                              $"Color: {Color} \n" +
                              $"Have a DVD player: {HasDVDPlayer}");
            Console.WriteLine();
            Console.ResetColor();
        
        }
    }
}
