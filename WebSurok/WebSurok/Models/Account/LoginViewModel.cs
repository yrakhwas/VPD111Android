namespace WebSurok.Models.Account
{
    public class LoginViewModel
    {
        /// <summary>
        /// User`s login
        /// </summary>
        /// <example>admin@gmail.com</example>
        public string Email { get; set; }
        /// <summary>
        /// password
        /// </summary>
        /// <example>123456</example>
        public string Password { get; set; }
    }
}