string inputInfo = Console.ReadLine();

Catalog catalog = new Catalog();

while (inputInfo != "end")
{
    string[] arrInputInfo = inputInfo.Split("/");
    
    string brand = arrInputInfo[1];
    string model = arrInputInfo[2];
    string value = arrInputInfo[3];

   

    string type = arrInputInfo[0];
    
    if (type == "Truck")
    {
        Truck truck = new Truck
        {
            Brand = brand,
            Model = model,
            Weight = value
        };
        catalog.trucksList.Add(truck);
    }
    else if(type == "Car")
    {
        Car car = new Car
        {
            Brand = brand,
            Model = model,
            HorsePower = value
        };
        catalog.carsList.Add(car);
    }

    inputInfo = Console.ReadLine();
}

if (catalog.carsList.Count > 0)
{
    Console.WriteLine("Cars:");
    Console.WriteLine(string.Join(Environment.NewLine, catalog.carsList
        .OrderBy(x => x.Brand)
        .Select(x => $"{x.Brand}: {x.Model} - {x.HorsePower}hp")));
}
if (catalog.trucksList.Count > 0)
{
    Console.WriteLine("Trucks:");
    Console.WriteLine(string.Join(Environment.NewLine, catalog.trucksList
        .OrderBy(x => x.Brand)
        .Select(x => $"{x.Brand}: {x.Model} - {x.Weight}kg")));
}


class Catalog
{
    public List<Car> carsList = new List<Car>();

    public List<Truck> trucksList = new List<Truck>();
}

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

-----------------------------------------------------------------------------
 //using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _07.Vehicle_Catalogue
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] input = Console.ReadLine().Split("/").ToArray();
//            Catalog catalog = new Catalog();

//            while (input[0] != "end")
//            {
//                string type = input[0];
//                string brand = input[1];
//                string model = input[2];
//                string horsePower = " ";
//                string weight = " ";

//                if (type == "Car")
//                {
//                    horsePower = input[3];
//                    Car newCar = new Car(brand, model, horsePower);
//                    catalog.Cars.Add(newCar);

//                }
//                else if (type == "Truck")
//                {
//                    weight = input[3];
//                    Truck newTruck = new Truck(brand, model, weight);
//                    catalog.Trucks.Add(newTruck);
//                }

//                input = Console.ReadLine().Split("/").ToArray();
//            }

//            if (catalog.Cars.Count > 0)
//            {
//                Console.WriteLine("Cars:");
//                foreach (Car car in catalog.Cars.OrderBy(car => car.Brand))
//                {
//                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
//                }
//            }
//            if (catalog.Trucks.Count > 0)
//            {
//                Console.WriteLine("Trucks:");
//                foreach (Truck truck in catalog.Trucks.OrderBy(truck => truck.Brand))
//                {
//                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
//                }

//            }
//        }

//    }

//    class Car
//    {
//        public Car(string brand, string model, string horsePower)
//        {
//            Brand = brand;
//            Model = model;
//            HorsePower = horsePower;
//        }

//        public string Brand { get; set; }
//        public string Model { get; set; }
//        public string HorsePower { get; set; }
//    }

//    class Truck
//    {
//        public Truck(string brand, string model, string weight)
//        {
//            Brand = brand;
//            Model = model;
//            Weight = weight;
//        }
//        public string Brand { get; set; }
//        public string Model { get; set; }
//        public string Weight { get; set; }
//    }

//    class Catalog
//    {
//        public Catalog()
//        {
//            Cars = new List<Car>();
//            Trucks = new List<Truck>();
//        }
//        public List<Car> Cars { get; set; }
//        public List<Truck> Trucks { get; set; }
//    }

//}
