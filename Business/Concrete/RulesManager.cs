using System;
using Entities.Concrete;
using Business.Abstract;

namespace Business.Concrete
{
    public class RulesManager : IRulesService
    {
        public void CheckNameAndDailyPrice(Car car)
        {
            if (car.Description.Length < 2)
            {
                throw new Exception("Description field must be two character at least.");
            }
            if (car.DailyPrice <= 0)
            {
                throw new Exception("DailyPrice field cannot be equal to or less than 0");
            }
        }
    }
}
