using Domain_Service.Enums;
using System.ComponentModel.DataAnnotations;

namespace Application_Service.Entities.UserModule.Users
{
    /// <summary>
    /// Represents a user within the system.
    /// </summary>
    /// <remarks>
    /// The <see cref="User"/> class contains all relevant information about a system user,
    /// including identity, contact information, status, and timestamps for creation and updates.
    /// This class is intended to be used across the domain and service layers wherever user data is required.
    /// </remarks>
    public class User
    {
        [Key]
        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        public Guid U_Id { get; set; } 


        /// <summary>
        /// Gets or sets the full name of the user.
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL of the user's profile image.
        /// </summary>
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the username used for login or display purposes.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>I
        /// Gets or sets the user's email address.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's contact number.
        /// </summary>
        public string Contact { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the current status of the user (e.g., Active, Inactive, Suspended).
        /// </summary>
        public UserStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the date when the user account was created.
        /// </summary>
        public DateOnly CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the user account was last updated.
        /// </summary>
        public DateTime UpdatedAt { get; set; }

    }
}
