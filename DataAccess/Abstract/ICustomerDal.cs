using System;
using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Abstract
{
  public interface ICustomerDal : IEntityRepository<Customer>
  {

  }
}