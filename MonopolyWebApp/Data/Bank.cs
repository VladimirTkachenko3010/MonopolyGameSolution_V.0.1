namespace MonopolyWebApp.Models
{
    public class Bank
    {
        /// <summary>
        /// BankId of Bank
        /// </summary>
        public int BankId { get; set; }
    
        /// <summary>
        /// GameId of Bank
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// Bank Money of current game
        /// </summary>
        public int BankMoney { get; set; }
    }
}
