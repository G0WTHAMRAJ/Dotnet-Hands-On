using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    internal class Program
    {
        enum Names { Gowtham, Nivy, Jai, Mojo };
        static void Main(string[] args)
        {
            Car sportsCar = new SportsCar("Ferrari", "488 GTB", 2021, 330);
            Car electricCar = new ElectricCar("Tesla", "Model S", 2023, 100);
            Car suv = new SUV("Toyota", "Highlander", 2022, 7);

            Console.WriteLine(sportsCar.GetDetails());
            Console.WriteLine(sportsCar.GetCarType());
            Console.WriteLine();

            Console.WriteLine(electricCar.GetDetails());
            Console.WriteLine(electricCar.GetCarType());
            Console.WriteLine();

            Console.WriteLine(suv.GetDetails());
            Console.WriteLine(suv.GetCarType());


            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your age");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your nationality");
            //string nation = Console.ReadLine();
            //if (age < 18 || nation.Equals("indian"))
            //{
            //    Console.WriteLine($"{name} not eligible for vote");
            //}
            //else
            //{
            //    Console.WriteLine($"{name} eligible for vote");
            //}
            //Console.WriteLine("Enter number");
            //int number=int.Parse(Console.ReadLine());
            //for(int i = 0; i <= number; i++) {
            //    if (i == 3 || i == 9)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            // Using 2D Array
            //string[,] car = { { "mustag", "14000000", "1987" }, 
            //    {"porche","4000000","2001" },
            //    {"benz","1000000","1998"} };
            //for(int i = 0;i < car.GetLength(0); i++)
            //{
            //    if (car[i, 2] == "2001")
            //    {
            //        Console.Write("Car " + i + " :");
            //    }
            //    for(int j = 0;j < car.GetLength(1); j++)
            //    {
            //        Console.Write(car[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int FirstName= (int)Names.Gowtham;
            //int LastName = (int)Names.Mojo;

            //Console.WriteLine("Gowtham: {0}",FirstName);
            //Console.WriteLine("Mojo: {0}", LastName);
            Overloading car = new Overloading("Toyota", "Camry");

            // Call different overloads of Start method
            car.Start();
            car.Start("smart");
            car.Start(true, "keyless");

            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            Console.WriteLine(arrayList);


            Console.ReadKey();
        }
    }
}
