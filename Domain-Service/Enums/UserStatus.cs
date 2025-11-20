namespace Domain_Service.Enums
{
    /// <summary>
    /// Defines the possible statuses of a user within the system.
    /// </summary>
    /// <remarks>
    /// The <see cref="UserStatus"/> enum is used to track and manage 
    /// the current state of a user account, which can affect authentication, 
    /// access rights, and visibility within the application.
    /// </remarks>
    public enum UserStatus
    {
        /// <summary>
        /// The user account is active and has full access to the system.
        /// </summary>
        Active = 1,

        /// <summary>
        /// The user account is inactive, meaning the user cannot currently log in.
        /// </summary>
        Inactive = 2,

        /// <summary>
        /// The user account is suspended temporarily, usually due to policy violations.
        /// </summary>
        Suspended = 3,

        /// <summary>
        /// The user account is deleted or removed from the system.
        /// </summary>
        Deleted = 4
    }
}
