using System;
using Entities.Concrete;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface IBrandDal : IEntityRepository<Brand>
    {
    }
}
