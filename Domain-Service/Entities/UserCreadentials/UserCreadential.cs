using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Service.Entities.UserCreadentials
{
    public class UserCreadential
    {
        public Guid Cread_Id { get; set; }
        public Guid U_Id { get; set; }
        public byte[] PasswordHash { get; set; } = [];
        public byte[] PasswordSalt { get; set; } = [];
        public string OTP { get; set; } = string.Empty;
    }
}
