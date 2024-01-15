using System;

namespace MonopolyWebApp.Models
{
    public class Game
    {
        /// <summary>
        /// GameId of current game
        /// </summary>
        public int GameId { get; set; }

        /// <summary>
        /// PlayersID of current game
        /// </summary>
        public int PlayersID {get; set; }

        /// <summary>
        /// HistoryID of current game
        /// </summary>
        public int HistoryID { get; set; }

        /// <summary>
        /// BankID of current game
        /// </summary>
        public int BankID { get; set; }

        /// <summary>
        /// BoardId of current game
        /// </summary>
        public int BoardID { get; set; }

        /// <summary>
        /// Game Status of current game
        /// </summary>
        public string GameStatus { get; set;}
        
        /// <summary>
        /// Time played of current game
        /// </summary>
        public DateTime GameTime { get; set;}
    }
}
