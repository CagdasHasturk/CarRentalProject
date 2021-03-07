using System;
using Entities.Concrete;
using DataAccess.Abstract;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarRentalContext>,ICustomerDal {
      
    }
}