using System;
using System.Collections.Generic;
using Entities.Concrete;
using Business.Abstract;
using DataAccess.Abstract;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
  public class RentalManager : IRentalService
  {

    private IRentalDal _rentalDal;

    public RentalManager(IRentalDal rentalDal)
    {
      _rentalDal = rentalDal;
    }
    public IResult Add(Rental rental)
    {
      _rentalDal.Add(rental);
      return new SuccessResult();
    }

    public IResult Delete(Rental rental)
    {
      _rentalDal.Delete(rental);
      return new SuccessResult();
    }

    public IResult Update(Rental rental)
    {
      _rentalDal.Update(rental);
      return new SuccessResult();
    }

    public IDataResult<List<Rental>> GetAll()
    {
      return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
    }

    public IDataResult<Rental> GetById(int id)
    {
      return new  SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
    }


  }
}