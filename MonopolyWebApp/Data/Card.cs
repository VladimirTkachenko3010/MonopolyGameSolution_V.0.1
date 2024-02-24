using System;
using System.ComponentModel;

namespace MonopolyWebApp.Models
{
    public class Card
    {
        #region properties

        /// <summary>
        /// CardId of Card
        /// </summary>
        public int CardId { get; set; }

        /// <summary>
        /// ChanceId of Card
        /// </summary>
        public int ChanceId { get; set; }

        /// <summary>
        /// CardType of Card
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// Price of Card
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// description of card
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }
        }

        /// <summary>
        /// action of card
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// description of card(chance)
        /// </summary>
        private string description;

        /// <summary>
        /// action of card(chance)
        /// </summary>
        private string action;

        #endregion

        /// <summary>
        /// default ctor
        /// </summary>
        public Card()
        {
            description = "N/A";
            action = "N/A";
        }

        /// <summary>
        /// ctor that allows for initialization of the description and the action.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="action"></param>
        public Card(string description, string action)
        {
            this.description = description;
            this.action = action;
        }
    }
}
