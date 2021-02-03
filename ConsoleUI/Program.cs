using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("====================================");
                Console.WriteLine("Id of the car:" + car.Id);
                Console.WriteLine("BrandId of the car:" + car.BrandId);
                Console.WriteLine("Model Year of the car:" + car.ModelYear);
                Console.WriteLine("Description:" + car.Description);
                Console.WriteLine("Price of the car:" + car.DailyPrice);
                Console.WriteLine("------------------------------------");
            }

            Console.WriteLine("====================================");
            foreach (var car in carManager.GetByID(2))
            {
                Console.WriteLine("Id of the car:" + car.Id);
                Console.WriteLine("BrandId of the car:" + car.BrandId);
                Console.WriteLine("Model Year of the car:" + car.ModelYear);
                Console.WriteLine("Description :" + car.Description);
                Console.WriteLine("Price of the car:" + car.DailyPrice);
                Console.WriteLine("------------------------------------");

            };

            Car car1 = new Car
            {
                Id = 5,
                ColorId = 2,
                BrandId = 8,
                DailyPrice = 65000,
                Description = "Private car for elegant customers",
                ModelYear = 2020
            };

            Console.WriteLine("====================================");
            Console.WriteLine("Id of the car:" + car1.Id);
            Console.WriteLine("BrandId of the car:" + car1.BrandId);
            Console.WriteLine("Model Year of the car:" + car1.ModelYear);
            Console.WriteLine("Description :" + car1.Description);
            Console.WriteLine("Price of the car:" + car1.DailyPrice);
            Console.WriteLine("------------------------------------");
            carManager.Delete(car1);

            Car car2 = new Car
            {
                Id = 6,
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 45000,
                Description = "Huge discount for our customers",
                ModelYear = 2019
            };

            Console.WriteLine("====================================");
            Console.WriteLine("Id of the car:" + car2.Id);
            Console.WriteLine("BrandId of the car:" + car2.BrandId);
            Console.WriteLine("Model Year of the car:" + car2.ModelYear);
            Console.WriteLine("Description:" + car2.Description);
            Console.WriteLine("Price of the car:" + car2.DailyPrice);
            Console.WriteLine("------------------------------------");
            carManager.Add(car2);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            carManager.Update(new Car {Id = 1, BrandId = 3, ModelYear = 2021, DailyPrice = 70000, Description = "'FIRST CAR OF THE YEAR'" });

            




        }
    }
}
