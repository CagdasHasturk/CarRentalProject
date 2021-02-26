using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Entities.Concrete;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarRentalContext>,IBrandDal
    {
    }
}
