using Core.DataAccess.EntityFramework;
using Core.Entities;
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
                             select new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName, ColorName = cl.ColorName, DailyPrice = c.DailyPrice, Description = c.Descriptions, BrandId = c.BrandId, ColorId = c.ColorId };

                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrand(int brandId)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                var result = from c in context.Cars where c.BrandId == brandId
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName, ColorName = cl.ColorName, DailyPrice = c.DailyPrice, Description = c.Descriptions, BrandId = c.BrandId, ColorId = c.ColorId };

                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColor(int colorId)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                var result = from c in context.Cars where c.ColorId == colorId
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName, ColorName = cl.ColorName, DailyPrice = c.DailyPrice, Description = c.Descriptions, BrandId = c.BrandId, ColorId = c.ColorId };

                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsById(int carId)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                var result = from c in context.Cars where c.CarId == carId
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName, ColorName = cl.ColorName, DailyPrice = c.DailyPrice, Description = c.Descriptions, BrandId = c.BrandId, ColorId = c.ColorId};

                return result.ToList();
            }
        }
    }
}
