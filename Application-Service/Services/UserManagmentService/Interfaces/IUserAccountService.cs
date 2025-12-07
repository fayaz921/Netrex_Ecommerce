using Application_Service.DTO_s.UserDto.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Services.UserManagmentService.Interfaces
{
    public interface IUserAccountService
    {
        Task<string> UserRegisterationAsync(UserRegisterDto request);
    }
}
