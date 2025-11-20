using Domain_Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Service.Entities.Roles
{
    public class UserRole
    {
        public Guid UR_Id { get; set; }
        public RoleType Role { get; set; }
    }
}
