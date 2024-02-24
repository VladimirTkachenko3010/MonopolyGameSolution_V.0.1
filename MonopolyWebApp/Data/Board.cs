using MonopolyWebApp.Data;
using MonopolyWebApp.Application;
using System.Collections.Generic;

namespace MonopolyWebApp.Models
{
    public class Board
    {
        #region Свойства доски

        /// <summary>
        /// GameId for Board
        /// </summary>
        public int GameId { get; set; }

        /// <summary>
        /// BoardId for Board
        /// </summary>
        public int BoardID { get; set; }

        /// <summary>
        /// BranchId for Board
        /// </summary>
        public int BranchdID { get; set; }

        /// <summary>
        /// BoardApp
        /// </summary>
        public BoardApp boardApp;

        /// <summary>
        /// An array of spaces that represent the game board.
        /// </summary>
        public List<Space> spaceContainer;

        /// <summary>
        /// decks
        /// </summary>
        public DeckApp deckApp;

        public List<Card> chanceDeckList;

        public List<Card> communityChestDeckList;
        

        #endregion

        public Board()
        {
            deckApp = new DeckApp();
            chanceDeckList = new List<Card>();
            communityChestDeckList = new List<Card>();
            spaceContainer = new List<Space>();
            boardApp = new BoardApp();

            boardApp.FillBoard(spaceContainer,chanceDeckList,communityChestDeckList, deckApp);
        }
    }
}
