using System;
using System.Collections.Generic;
using Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
  public interface IRentalService
  {
    IDataResult<Rental> GetById(int id);
    IDataResult<List<Rental>> GetAll();
    IResult Add(Rental rental);
    IResult Update(Rental rental);
    IResult Delete(Rental rental);
  }
}