using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        DataResult<List<Customer>> GetAll();
        DataResult<Customer> GetById(int customerId);
        Result Add(Customer customer);
        Result Update(Customer customer);
        Result Delete(Customer customer);
    }
}
