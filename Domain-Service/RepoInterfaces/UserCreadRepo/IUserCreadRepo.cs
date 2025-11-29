using Application_Service.Entities.UserModule.UserCreadentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Service.RepoInterfaces.UserCreadRepo
{
    public interface IUserCreadRepo
    {
        Task AddUserCread(UserCreadential usercread);
    }
}
