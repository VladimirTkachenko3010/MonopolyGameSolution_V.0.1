using MonopolyWebApp.Models;
using System.Collections.Generic;

namespace MonopolyWebApp.Data
{
    public class Deck
    {
        /// <summary>
        /// default ctor
        /// </summary>
        public Deck()
        {
            var deck = new List<Card>();
        }

        /// <summary>
        /// ctor that initializes a deck of cards specified by the string passed in.
        /// </summary>
        /// <param name="deckName"></param>
        public Deck(string deckName)
        {
            // Only initialize the deck if the name is either "Chance" or "Community."
            if (deckName == "Chance")
            {
                // Add the Chance cards to the deck.
                var deck = new List<Card>();
                deck.Add(new Card("desc", "action"));
            }
            else if (deckName == "Community")
            {
                //
            }
        }
    }
}
