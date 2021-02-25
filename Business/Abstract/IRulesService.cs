using System;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRulesService
    {
        void CheckNameAndDailyPrice(Car car);
    }
}
