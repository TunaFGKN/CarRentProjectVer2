using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        DataResult<List<Rental>> GetAll();
        DataResult<Rental> GetById(int rentalId);
        Result Add(Rental rental);
        Result Update(Rental rental);
        Result Delete(Rental rental);
    }
}
