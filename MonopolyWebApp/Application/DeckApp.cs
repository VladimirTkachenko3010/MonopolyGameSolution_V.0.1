using MonopolyWebApp.Models;
using MonopolyWebApp.Data;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace MonopolyWebApp.Application
{
    public class DeckApp
    {

        #region funcs

        /// <summary>
        /// shuffles the deck twice(for a good shuffle)
        /// </summary>
        /// <param name="deck"></param>
        public void ShuffleDeck(List<Card> deck)
        {
            Random rand = new Random();
            for (int i = 0; i < (deck.Count*2); i++)
            {
                int randIndex = rand.Next(0,16);
                Card randCard = (Card)deck[randIndex];
                deck.RemoveAt(randIndex);
                deck.Add(randCard);
            }
        }

        /// <summary>
        /// Gets the card on the top of the deck.
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        public Card GetCardOnTop(List<Card> deck)
        {
            return (Card)deck[0];
        }

        /// <summary>
        /// Moves the card from the top of the deck to the bottom.
        /// </summary>
        /// <param name="deck"></param>
        public void MoveTopCardToBottom(List<Card> deck)
        {
            Card card = this.GetCardOnTop(deck);
            // Remove the card in the first position of the ArrayList, then add it back to the end of it.

            deck.RemoveAt(0);
            deck.Add(card);
        }

        #endregion
    }
}
