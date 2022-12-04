using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("/").ToArray();
            Catalog catalog = new Catalog();

            while (input[0] != "end")
            {
                string type = input[0];
                string brand = input[1];
                string model = input[2];
                string horsePower = " ";
                string weight = " ";

                if (type == "Car")
                {
                    horsePower = input[3];
                    Car newCar = new Car(brand, model, horsePower);
                    catalog.Cars.Add(newCar);

                }
                else if (type == "Truck")
                {
                    weight = input[3];
                    Truck newTruck = new Truck(brand, model, weight);
                    catalog.Trucks.Add(newTruck);
                }

                input = Console.ReadLine().Split("/").ToArray();
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }

            }
        }

    }

    class Car
    {
        public Car(string brand, string model, string horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

    class Truck
    {
        public Truck(string brand, string model, string weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

}
