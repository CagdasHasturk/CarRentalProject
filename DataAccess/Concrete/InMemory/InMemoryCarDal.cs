using System;
using System.Collections.Generic;
using System.Linq;
using Entities.Concrete;
using DataAccess.Abstract;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id =1, BrandId = 1, ColorId = 1, ModelYear = new DateTime(2020), DailyPrice = 1000, Description = "Son model bugatti" },
                new Car{Id =2, BrandId = 2, ColorId = 1, ModelYear = new DateTime(2005), DailyPrice = 200, Description = "Toyota hasarli" },
                new Car{Id =3, BrandId = 2, ColorId = 2, ModelYear = new DateTime(2000), DailyPrice = 400, Description = "Toyota saglam" },
                new Car{Id =4, BrandId = 3, ColorId = 2, ModelYear = new DateTime(2010), DailyPrice = 500, Description = "Reno" },
                new Car{Id =5, BrandId = 4, ColorId = 3, ModelYear = new DateTime(1990), DailyPrice = 200, Description = "Tofas" },
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Car carToDelete = null;
            //foreach (var c in _cars)
            //{
            //    if (c.Id == car.Id)
            //    {
            //        carToDelete = c;
            //    }
            //}
            //_cars.Remove(carToDelete);

            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
            
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _cars.First();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            //Car carFilterById = null;
            //foreach (var car in _cars)
            //{
            //    if (car.Id == id)
            //    {
            //        carFilterById = car;
            //    }
            //}
            //return carFilterById;

            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;

            //foreach (var c in _cars)
            //{
            //    if (c.Id == car.Id)
            //    {
            //        carToUpdate = c;
            //    }
            //}

            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
