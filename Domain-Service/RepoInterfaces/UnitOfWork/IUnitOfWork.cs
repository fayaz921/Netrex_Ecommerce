using Application_Service.Entities.UserModule.Roles;
using Application_Service.Entities.UserModule.UserCreadentials;
using Application_Service.Entities.UserModule.Users;
using Domain_Service.RepoInterfaces.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Service.RepoInterfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        IRepository<UserCreadential> Credentials { get; }
        IRepository<UserRole> UserRoles { get; }
        Task<int> SaveChangesAsync();
    }
}
