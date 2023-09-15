using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=800,ModelYear=2020,Descriptions="Fast Car"},
                new Car{CarId=2,BrandId=2,ColorId=1,DailyPrice=700,ModelYear=2018,Descriptions="Clean Car"},
                new Car{CarId=3,BrandId=3,ColorId=2,DailyPrice=750,ModelYear=2019,Descriptions="Comfort Car"},
                new Car{CarId=4,BrandId=3,ColorId=3,DailyPrice=850,ModelYear=2021,Descriptions="Good Car"},
                new Car{CarId=5,BrandId=4,ColorId=4,DailyPrice=750,ModelYear=2018,Descriptions="Manuel Car"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Descriptions = car.Descriptions;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
