using System;
using System.Collections.Generic;
using System.Linq;
using Entities.Concrete;
using DataAccess.Abstract;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id =1, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 1000, Description = "Son model bugatti" },
                new Car{Id =2, BrandId = 2, ColorId = 1, ModelYear = 2005, DailyPrice = 200, Description = "Toyota hasarli" },
                new Car{Id =3, BrandId = 2, ColorId = 2, ModelYear = 2000, DailyPrice = 400, Description = "Toyota saglam" },
                new Car{Id =4, BrandId = 3, ColorId = 2, ModelYear = 2010, DailyPrice = 500, Description = "Reno" },
                new Car{Id =5, BrandId = 4, ColorId = 3, ModelYear = 1990, DailyPrice = 200, Description = "Tofas" },
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

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
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
