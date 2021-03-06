using System;
using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetById(int id);

        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetCarsByBrandId(int id);

        IDataResult<List<Car>> GetCarsByColorId(int id);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);

        IResult Update(Car car);

        IResult Delete(Car car);
    }
}
