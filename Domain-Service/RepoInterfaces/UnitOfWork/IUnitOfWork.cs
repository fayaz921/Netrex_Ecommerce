using Domain_Service.Entities.Roles;
using Domain_Service.Entities.UserCreadentials;
using Domain_Service.Entities.Users;
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
