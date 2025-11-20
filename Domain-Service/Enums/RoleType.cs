namespace Domain_Service.Enums
{
    /// <summary>
    /// Defines the different types of roles that can be assigned to users in the system.
    /// </summary>
    /// <remarks>
    /// The <see cref="RoleType"/> enum is used to manage access control, permissions,
    /// and functionality available to users based on their assigned role.
    /// </remarks>
    public enum RoleType
    {
        /// <summary>
        /// Administrator role with full access to all system features and settings.
        /// </summary>
        Admin = 1,

        /// <summary>
        /// Regular user role with standard access rights to system features.
        /// </summary>
        User = 2,

        /// <summary>
        /// Customer role, typically representing end-users who purchase or use services.
        /// </summary>
        Customer = 3,

        /// <summary>
        /// Seller role, representing users who provide products or services through the system.
        /// </summary>
        Seller = 4
    }
}
