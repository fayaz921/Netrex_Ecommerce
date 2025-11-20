namespace Domain_Service.Entities.UserCreadentials
{
    /// <summary>
    /// Represents the authentication credentials for a system user.
    /// </summary>
    /// <remarks>
    /// The <see cref="UserCreadential"/> class stores sensitive information used for 
    /// user authentication, including password hash, salt, and one-time password (OTP).
    /// This class should be handled securely and is usually accessed only by authentication services.
    /// </remarks>
    public class UserCreadential
    {
        /// <summary>
        /// Gets or sets the unique identifier for this user credential record.
        /// </summary>
        public Guid Cread_Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the associated user.
        /// </summary>
        public Guid U_Id { get; set; }

        /// <summary>
        /// Gets or sets the hashed representation of the user's password.
        /// </summary>
        public byte[] PasswordHash { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// Gets or sets the cryptographic salt used when hashing the password.
        /// </summary>
        public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// Gets or sets the one-time password (OTP) for temporary verification purposes.
        /// </summary>
        public string OTP { get; set; } = string.Empty;
    }
}
