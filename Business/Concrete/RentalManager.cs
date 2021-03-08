using System;
using System.Linq;
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

        public bool isCarRentable(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId).SingleOrDefault(r => r.ReturnDate == null);

            if (result == null)
            {
                return true;
            }
            return false;
        }

        public IResult Add(Rental rental)
        {
            if (isCarRentable(rental))
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.CarRented);
            }

            return new ErrorResult(Messages.NotRentableCar);
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
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }


    }
}