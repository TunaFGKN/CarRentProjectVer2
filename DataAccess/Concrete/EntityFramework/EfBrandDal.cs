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
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                var addedEntity = context.Entry(entity); //Relate with data source
                addedEntity.State = EntityState.Added; // Add to data source
                context.SaveChanges(); //Save
            }
        }

        public void Delete(Brand entity)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                var deletedEntity = context.Entry(entity); //Relate with data source
                deletedEntity.State = EntityState.Deleted;  // Delete from data source
                context.SaveChanges(); //Save
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList(); // If the filter is null return all. If it is not than return filtered data
            }
        }

        public void Update(Brand entity)
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
