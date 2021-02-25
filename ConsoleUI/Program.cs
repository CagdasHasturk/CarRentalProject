using System;
using System.Collections.Generic;
using Entities.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Business.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 10,
                ModelYear = new DateTime(1900),
                Description = "Yeni Kayit"
            };

            CarManager carManager = new CarManager(new EfCarDal(), new RulesManager());
            carManager.Add(car);

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }

        }
    }
}
