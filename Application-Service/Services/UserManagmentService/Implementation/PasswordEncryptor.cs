using Application_Service.Services.UserManagmentService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Services.UserManagmentService.Implementation
{
    public class PasswordEncryptor : IPasswordEncryptor
    {
        public Task CreatePasswordHashAndSalt(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();

            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Task.CompletedTask;
        }

        public Task<bool> VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
        {
            using var hmac = new HMACSHA512(storedSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Task.FromResult(computedHash.SequenceEqual(storedHash));
        }
    }
}
