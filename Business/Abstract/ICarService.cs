using Core.Entities;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        DataResult<List<Car>> GetAll();
        DataResult<List<CarDetailDto>> GetCarDetails();
        DataResult<Car> GetById(int id);
        DataResult<List<Car>> GetAllByBrandId(int brandId);
        DataResult<List<Car>> GetAllByColorId(int colorId);
        DataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        Result Add(Car car);
        Result Update(Car car);
        Result Delete(Car car);
        DataResult<List<CarDetailDto>> GetCarDetailsByBrand(int brandId);
        DataResult<List<CarDetailDto>> GetCarDetailsByColor(int colorId);
        DataResult<List<CarDetailDto>> GetCarDetailsById(int carId);
    }
}
