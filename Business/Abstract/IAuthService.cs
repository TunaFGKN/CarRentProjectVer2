using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        DataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        DataResult<User> Login(UserForLoginDto userForLoginDto);
        Result UserExists(string email);
        DataResult<AccessToken> CreateAccessToken(User user);
    }
}
