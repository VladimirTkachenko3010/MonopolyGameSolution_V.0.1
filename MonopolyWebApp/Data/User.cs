namespace MonopolyWebApp.Models
{
    public class User
    {
        /// <summary>
        /// UserID of User
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// PlayerID of User
        /// </summary>
        public int PlayerID { get; set; }

        /// <summary>
        /// Username of User
        /// </summary>
        public string Username { get; set; } = null!;

        /// <summary>
        /// Password of User
        /// </summary>
        private string Password { get; set; } = null!;
    }
}
