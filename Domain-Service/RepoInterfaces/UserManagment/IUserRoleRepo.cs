using Application_Service.Entities.UserModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.RepoInterfaces.UserManagment
{
    public interface IUserRoleRepo
    {
        Task AddUserRole (UserRole userRole);
    }
}
