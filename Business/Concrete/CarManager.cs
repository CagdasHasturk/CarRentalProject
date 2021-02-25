using System;
using System.Collections.Generic;
using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        private ICarDal _carDal;
        private IRulesService _rules;

        public CarManager(ICarDal carDal, IRulesService rules)
        {
            _carDal = carDal;
            _rules = rules;
        }

        public void Add(Car car)
        {
            _rules.CheckNameAndDailyPrice(car);
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
