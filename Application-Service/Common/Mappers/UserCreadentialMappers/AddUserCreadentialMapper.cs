using Application_Service.Entities.UserModule;
using Application_Service.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Common.Mappers.UserCreadentialMappers
{
    public static class AddUserCreadentialMapper
    {
        public static UserCreadential MapForUserCread(this User user)
        {
            return new UserCreadential
            {
                Cread_Id = Guid.NewGuid(),
                U_Id = user.U_Id,
                OTP = new Random().Next(100000, 999999).ToString()

            };
        }
    }
}
