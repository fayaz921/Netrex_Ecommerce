using Application_Service.Entities.UserModule.Roles;
using Domain_Service.RepoInterfaces.UserRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Service.Persistance.Repositories.UserRoles
{
    public class UserRoleRepo : IUserRoleRepo
    {
        public Task AddUserRole(UserRole userRole)
        {
            throw new NotImplementedException();
        }
    }
}
