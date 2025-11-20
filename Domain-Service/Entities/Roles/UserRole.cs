using Domain_Service.Enums;

namespace Domain_Service.Entities.Roles
{
    /// <summary>
    /// Represents a role assigned to a user in the system.
    /// </summary>
    /// <remarks>
    /// The <see cref="UserRole"/> class is used to define the role of a user, 
    /// such as Admin, Moderator, or Regular User. 
    /// This helps in managing permissions and access control across the application.
    /// </remarks>
    public class UserRole
    {
        /// <summary>
        /// Gets or sets the unique identifier for this user role record.
        /// </summary>
        public Guid UR_Id { get; set; }

        /// <summary>
        /// Gets or sets the type of role assigned to the user.
        /// </summary>
        public RoleType Role { get; set; }
    }
}
