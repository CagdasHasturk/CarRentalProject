using System;
using System.Collections.Generic;
using Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
  public interface IUserService
  {
    IDataResult<User> GetById(int id);
    IDataResult<List<User>> GetAll();
    IResult Add(User user);
    IResult Update(User user);
    IResult Delete(User user);
  }
}