using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); // Read data from database. Can be filtered. If it is not filtered reads all datas
        T Get(Expression<Func<T, bool>> filter); // Read one data from database. Must be filtered
        void Add(T entity); // Add data to DB
        void Update(T entity); // Update data from DB
        void Delete(T entity); // Delete data from DB
    }
}
