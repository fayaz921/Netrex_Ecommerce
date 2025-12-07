using Application_Service.DTO_s.UserDto.Account;
using Application_Service.Entities.UserModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Common.Mappers.UserMappers
{
    public static class UserRegistrationMapper
    {
        public static User MapforUserReg(this UserRegisterDto dto)
        {
            return new User
            {
                U_Id = Guid.NewGuid(),
                Email = dto.email,
                Username = dto.username,
                Contact = dto.contact
            };
        }
    }
}
