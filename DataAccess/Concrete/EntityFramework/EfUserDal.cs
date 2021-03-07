using System;
using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
  public class EfUserDal : EfEntityRepositoryBase<User, CarRentalContext>, IUserDal
  {
    
  }
}