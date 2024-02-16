using MonopolyWebApp.Data;
using MonopolyWebApp.Models;
using System;
using System.Collections.Generic;

namespace MonopolyWebApp.Application
{
    public class BoardApp
    {

        public Space SpaceAt(Space[] spaceContainer, int a_index)
        {
            // Only return a space within the appropriate index range (0-39). If it's higher, return an error
            // and an empty space.
            if (a_index >= 0 && a_index <= 39) return spaceContainer[a_index];
            else
            {
                var msg = ("Error accessing the space: index" + a_index.ToString() + " is not within the range.");
                //Console.WriteLine("Error accessing the space: index" + a_index.ToString() + " is not within the range.");
                return new Space();
            }
        }

        public void BuildOn(Space[] spaceContainer, int a_index)
        {
            // Only build something on the space if the amount of buildings are less than 5.
            if (spaceContainer[a_index].BuildingAmount < 5)
            {
                //spaceContainer[a_index].AddBuilding(spaceContainer[a_index]);

                SpaceApp spaceApp = new SpaceApp();
                spaceApp.AddBuilding(spaceContainer[a_index]);
            }
            // Otherwise, return an error in the console window indicating such.
            else
            {
                var msg = ("You cannot build more than a hotel on a space.");
            }
        }


        public Card DrawFromDeck(List<Card> chanceDeckList, List<Card> communityChestDeckList, string a_deckName)
        {
            // Draw from the Chance deck if the deck name argument is "Chance." Otherwise, do Community Chest.
            if (a_deckName == "Chance")
            {
                DeckApp deckApp = new DeckApp();
                return deckApp.GetCardOnTop(chanceDeckList);
            }
            else
            {
                DeckApp deckApp = new DeckApp();
                return deckApp.GetCardOnTop(communityChestDeckList);
            }
        }
        // Puts the card at the top of the specified deck on the bottom.
        public void PutCardOnBottom(List<Card> chanceDeckList, List<Card> communityChestDeckList, string a_deckName)
        {
            DeckApp deckApp = new DeckApp();
            if (a_deckName == "Chance")
            {
                deckApp.MoveTopCardToBottom(chanceDeckList);
            }
            else
            {
                deckApp.MoveTopCardToBottom(communityChestDeckList);
            }
        }

        public Space GetSpaceWithProperty(Space[] spaceContainer, string a_propertyName)
        {
            // Search the board for the space we're looking for.
            for (int i = 0; i < 40; i++)
            {
                // If this is the space, return it.
                if (spaceContainer[i].Name == a_propertyName)
                {
                    return spaceContainer[i];
                }
            }
            // If it was not found, return an empty space.
            return new Space();
        }

    }
}
