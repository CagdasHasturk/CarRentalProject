using System;
using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Business.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal(), new RulesManager());

            //Add a new car 
            carManager.Add(new Car
            {
                CarName = "Alfa Romeo",
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 10,
                ModelYear = 2000,
                Description = "Yeni araba eklendi"
            });

            //Update a Car
            carManager.Update(new Car
            {
                Id = 1,
                CarName = "A10",
                BrandId = 3,
                ColorId = 4,
                DailyPrice = 100,
                ModelYear = 2000,
                Description = "Araba kaydi guncellendi"
            });

            //Delete a Car
            carManager.Delete(new Car
            {
                Id = 2,
                CarName = "Toyota",
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 100,
                ModelYear = 2000,
                Description = "Araba kaydi silindi"
            });


            //List all cars
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.Id} - {car.CarName}");
            }

            //List a car by id
            Car carToList = carManager.GetById(1);
            Console.WriteLine($"{carToList.Id} - {carToList.CarName}");

            //List car details by id
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine($"Car name : {car.CarName}\nBrand name : {car.BrandName}\n" +
                    $"Color name : {car.CarName}\nDaily price : {car.DailyPrice}\n");
            }
           


        }
    }
}
