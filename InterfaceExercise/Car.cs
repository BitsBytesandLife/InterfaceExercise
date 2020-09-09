using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {


        public Car(string name, string logo, string model,  string intColor, int year, string color)
        {
            Name = name;
            Logo = logo;
            Model = model;
            InteriorColor= intColor;
            Year = year;
            AirBags = true;
            Wheels = 4;
            Color = color;
        }
        
        public string InteriorColor { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Wheels { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public bool AirBags { get; set; }

        public string Color { get; set; }


        public void Drive()
        {
            Console.WriteLine($"The {Model} is in drive.");
        }

        public void DisplayCar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Car Details: \n" +
                              $"Make: {Name} \n" +
                              $"Model: {Model} \n" +
                              $"Interior Color: {InteriorColor}\n"+
                              $"Year: {Year} \n" +
                              $"Air Bags: {AirBags}\n" +
                              $"Color: {Color}");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
