using Application_Service.Entities.UserModule.UserCreadentials;
using Domain_Service.RepoInterfaces.UserCreadRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Service.Persistance.Repositories.UserCreadRepo
{
    public class UserCreadRepo : IUserCreadRepo
    {
        public Task AddUserCread(UserCreadential usercread)
        {
            throw new NotImplementedException();
        }
    }
}
