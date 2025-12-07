using Application_Service.Common.Mappers.UserCreadentialMappers;
using Application_Service.Common.Mappers.UserMappers;
using Application_Service.Common.Mappers.UserRoleMappers;
using Application_Service.DTO_s.UserDto.Account;
using Application_Service.Services.UserManagmentService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Services.UserManagmentService.Implementation
{
    public class UserAccountService : IUserAccountService
    {
        private readonly IPasswordEncryptor passwordEncryptor;
        public UserAccountService(IPasswordEncryptor _passwordEncryptor)
        {
            passwordEncryptor = _passwordEncryptor;
        }
        public Task<string> UserRegisterationAsync(UserRegisterDto request)
        {
            var UserDomain = request.MapforUserReg();
            var UserRole = UserDomain.MapforUserRole();
            var UserCread = UserDomain.MapForUserCread();
            passwordEncryptor.CreatePasswordHashAndSalt(request.password, out byte[] passwordHash, out byte[] passwordSalt);
            UserCread.PasswordHash = passwordHash;
            UserCread.PasswordSalt = passwordSalt;
            return Task.FromResult("User Registered Successfully");

        }
    }
}
