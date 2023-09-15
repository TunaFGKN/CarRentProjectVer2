using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                var result = from c in context.Cars
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName, ColorName = cl.ColorName, DailyPrice = c.DailyPrice, Description = c.Descriptions };

                return result.ToList();                             
            }
        }
    }
}
