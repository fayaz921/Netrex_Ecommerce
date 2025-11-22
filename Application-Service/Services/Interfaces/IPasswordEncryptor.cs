using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Services.Interfaces
{
    public interface IPasswordEncryptor
    {
        Task CreatePasswordHashAndSalt(string password, out byte[] passwordHash, out byte[] passwordSalt);
        Task<bool> VerifyPassword(string password, byte[] storedHash, byte[] storedSalt);
    }
}
