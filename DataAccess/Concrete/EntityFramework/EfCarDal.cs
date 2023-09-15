using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                var addedEntity = context.Entry(entity); //Relate with data source
                addedEntity.State = EntityState.Added; // Add to data source
                context.SaveChanges(); //Save
            }
        }

        public void Delete(Car entity)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                var deletedEntity = context.Entry(entity); //Relate with data source
                deletedEntity.State = EntityState.Deleted;  // Delete from data source
                context.SaveChanges(); //Save
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList(); // If the filter is null return all. If it is not than return filtered data
            }
        }

        public void Update(Car entity)
        {
            using (CarRentDBContext context = new CarRentDBContext()) 
            {
                var updatedEntity = context.Entry(entity); //Relate with data source
                updatedEntity.State = EntityState.Modified;  // Update data source
                context.SaveChanges(); //Save
            }
        }
    }
}
