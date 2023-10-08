using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        DataResult<List<User>> GetAll();
        DataResult<User> GetById(int userId);
        Result Add(User user);
        Result Update(User user);
        Result Delete(User user);
        DataResult<User> GetByMail(string email);
        DataResult<List<OperationClaim>> GetClaims(User user);
    }
}
