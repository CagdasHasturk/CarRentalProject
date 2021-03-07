using System;
using Entities.Concrete;
using DataAccess.Abstract;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
  public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
  {

  }
}