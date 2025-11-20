using Domain_Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Service.Entities.Users
{
    public class User
    {
        public Guid U_Id { get; set; }  
        public Guid UR_Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public UserStatus Status { get; set; }
        public DateOnly CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }




    }
}
