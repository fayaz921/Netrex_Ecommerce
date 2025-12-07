using Application_Service.Entities.UserModule;
using Application_Service.RepoInterfaces.UserManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Persistance.Repositories.UserManagment
{
    public class UserRepo : IUserRepo
    {
        public Task UserRegistration(User user)
        {
            throw new NotImplementedException();
        }
    }
}
