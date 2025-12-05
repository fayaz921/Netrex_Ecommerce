using Application_Service.Entities.PaymentAndPayoutModule;
using Application_Service.Entities.UserModule.Roles;
using Application_Service.Entities.UserModule.UserCreadentials;
using Application_Service.Entities.UserModule.Users;
using Domain_Service.RepoInterfaces.GenericRepo;
using Domain_Service.RepoInterfaces.UnitOfWork;
using Infrastructure_Service.Data;
using Infrastructure_Service.Persistance.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Service.Persistance.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public IRepository<User> Users => new Repository<User>(_context);

        public IRepository<UserCreadential> Credentials => new Repository<UserCreadential>(_context);

        public IRepository<UserRole> UserRoles => new Repository<UserRole>(_context);

        public IRepository<Invoice> Invoices => throw new NotImplementedException();

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
