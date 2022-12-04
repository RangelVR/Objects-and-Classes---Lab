using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Car
    {
        
        public string Brand { get; set; }

        public string Model { get; set; }

        public string HorsePower { get; set; }
    }

    class Truck
    {
        
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Weight { get; set; }
    }

    class Catalog
    {
        public Catalog ()
        {
            Cars = new List<Car>();

            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Catalog catalogType = new Catalog();

            while (input != "end")
            {
                string[] arrInput = input.Split("/", StringSplitOptions.RemoveEmptyEntries);

                string type = arrInput[0];
                string brand = arrInput[1];
                string model = arrInput[2];
                string weightHorsePower = arrInput[3];

                if (type == "Car")
                {
                    Car newCar = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = weightHorsePower
                    };
                    catalogType.Cars.Add(newCar);
                }
                else if (type == "Truck")
                {
                    Truck newTruck = new Truck() 
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weightHorsePower
                    };
                    catalogType.Trucks.Add(newTruck);
                }

                input = Console.ReadLine();
            }

            catalogType.Cars = catalogType.Cars
                .OrderBy(x => x.Brand)
                .ToList();

            catalogType.Trucks = catalogType.Trucks
                .OrderBy(x => x.Brand)
                .ToList();

            if (catalogType.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in catalogType.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalogType.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in catalogType.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
