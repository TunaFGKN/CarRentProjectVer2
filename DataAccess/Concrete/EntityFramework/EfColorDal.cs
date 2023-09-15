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
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                var addedEntity = context.Entry(entity); //Relate with data source
                addedEntity.State = EntityState.Added; // Add to data source
                context.SaveChanges(); //Save
            }
        }

        public void Delete(Color entity)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                var deletedEntity = context.Entry(entity); //Relate with data source
                deletedEntity.State = EntityState.Deleted;  // Delete from data source
                context.SaveChanges(); //Save
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (CarRentDBContext context = new CarRentDBContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList(); // If the filter is null return all. If it is not than return filtered data
            }
        }

        public void Update(Color entity)
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
