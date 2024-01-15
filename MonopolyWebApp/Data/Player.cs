using System.Collections;

namespace MonopolyWebApp.Models
{
    public class Player
    {
        #region Свойства игрока
       
        /// <summary>
        /// PlayerID of Player
        /// </summary>
        public int PlayerID { get; set; }
        /// <summary>
        /// UserID of Player
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// GameID of Player
        /// </summary>
        public int GameID { get; set; }
        /// <summary>
        /// PlayerMoney of Player
        /// </summary>
        public int PlayerMoney { get; set; }
        /// <summary>
        /// Карточки выхода из тюрьмы
        /// </summary>
        public ushort GetOutOfJailAmount { get; set; }
        /// <summary>
        /// Кол-во ходов в тюрьме
        /// </summary>
        public ushort JailTurnCount { get; set; }
        /// <summary>
        /// Count of doubles of dice
        /// </summary>
        public ushort DoublesCount{ get;set; }
        /// <summary>
        /// Position of Player on board
        /// </summary>
        public ushort BoardPos { get; set; }
        /// <summary>
        /// Not/InJail
        /// </summary>
        public bool InJail { get; set; } = false;
        /// <summary>
        /// Houses of player
        /// </summary>
        public ushort HouseAmount { get; set; }
        /// <summary>
        /// hotels of Player
        /// </summary>
        public ushort HotelAmount { get; set;}
        /// <summary>
        /// dice roll 2-12
        /// </summary>
        public ushort DiceRoll{ get; set;}
        /// <summary>
        /// The player's "position" in the player roster.
        /// </summary>
        public ushort RosterPosition { get; set;}
        /// <summary>
        /// Not/Passed go
        /// </summary>
        public bool PassedGo { get; set; } = false;
        /// <summary>
        /// Player prors
        /// </summary>
        ArrayList PlayerProperties = new ArrayList();

        #endregion

        //Default ctor
        public Player()
        {
            PlayerID = 0;
            UserID = 0;
            GameID = 0;
            //startMoney
            PlayerMoney = 1500;
            GetOutOfJailAmount = 0;
            JailTurnCount = 0;
            DoublesCount = 0;
            BoardPos = 0;
            InJail = false;
            HouseAmount = 0;
            HotelAmount = 0;
            DiceRoll = 0;
            RosterPosition = 0;
            PassedGo = false;
            PlayerProperties = new ArrayList();
        }
    }
}
