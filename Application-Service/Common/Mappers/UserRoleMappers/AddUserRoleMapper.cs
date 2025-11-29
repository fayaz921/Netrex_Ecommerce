using Application_Service.Entities.UserModule.Roles;
using Application_Service.Entities.UserModule.Users;
using Domain_Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Common.Mappers.UserRoleMappers
{
    public static class AddUserRoleMapper
    {
        public static UserRole MapforUserRole(this User user)
        {
            return new UserRole
            {
                UR_Id = Guid.NewGuid(),
                U_Id = user.U_Id,
                Role = RoleType.Customer
            };
        }
    }
}
