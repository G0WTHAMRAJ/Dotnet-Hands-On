using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    public abstract class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

  
        protected Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public abstract string GetCarType();

  
        public string GetDetails()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}";
        }
    }

    public class SportsCar : Car
    {
        public int TopSpeed { get; set; }

        public SportsCar(string make, string model, int year, int topSpeed)
            : base(make, model, year)
        {
            TopSpeed = topSpeed;
        }

        public override string GetCarType()
        {
            return $"This is a sports car with a top speed of {TopSpeed} km/h.";
        }
    }

    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; } 

        public ElectricCar(string make, string model, int year, int batteryCapacity)
            : base(make, model, year)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override string GetCarType()
        {
            return $"This is an electric car with a battery capacity of {BatteryCapacity} kWh.";
        }
    }


    public class SUV : Car
    {
        public int SeatingCapacity { get; set; }

        public SUV(string make, string model, int year, int seatingCapacity)
            : base(make, model, year)
        {
            SeatingCapacity = seatingCapacity;
        }

        public override string GetCarType()
        {
            return $"This is an SUV with a seating capacity of {SeatingCapacity} passengers.";
        }
    }
   
}
