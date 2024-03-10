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
        public Deck(List<Card> deck, string deckName)
        {
            // Only initialize the deck if the name is either "Chance" or "Community."
            if (deckName == "Chance")
            {
                // Add the Chance cards to the deck.
                
                //var deck = new List<Card>();
                
                #region chance deck cards

                deck.Add(new Card("Advance to Go (collect 200$)", "advanceGo"));
                deck.Add(new Card("Advance to Trafalgar Square(prop17). If you pass Go, collect $200", "advanceProp17"));
                deck.Add(new Card("Advance to PallMall(prop7) If you pass Go, collect $200", "advanceProp7"));
                deck.Add(new Card("Advance to nearest Utility", "advanceUtility"));

                deck.Add(new Card("Advance to nearest Railroad", "advanceRailroad"));
                deck.Add(new Card("Advance to nearest Railroad", "advanceRailroad"));
                deck.Add(new Card("Bank pays you dividend of $50", "bankDividend"));
                deck.Add(new Card("Get Out of Jail Free!", "jailFree"));

                deck.Add(new Card("Go back 3 spaces", "goBack3"));
                deck.Add(new Card("Go directly to Jail. Do not pass Go, do not collect $200", "jail"));
                deck.Add(new Card("Make general repairs on all your property. For each house, pay $25. For each hotel, pay $100.", "generalRepairs"));
                deck.Add(new Card("Pay Poor Tax of $15", "poorTax"));

                deck.Add(new Card("Advance to King Cross St(prop3). If you pass Go, collect $200", "advanceProp3"));
                deck.Add(new Card("Advance to Mayfair(prop28). If you pass Go, collect $200", "advanceProp28"));
                deck.Add(new Card("You have been elected Chairman of the Board. Pay each player $50", "chairman"));
                deck.Add(new Card("Your building and loan matures. Collect $150", "matures"));

                #endregion
            }
            else if (deckName == "Community")
            {
                //Add the Community Chest cards to the deck.
               
                //var deck = new List<Card>();

                #region community chest cards

                deck.Add(new Card("Advance to Go (collect 200$)", "advanceGo"));
                deck.Add(new Card("Bank error in your favor. Collect $200", "bankError"));
                deck.Add(new Card("Doctor's fee. Pay $50", "doctorsFee"));
                deck.Add(new Card("From sale of stock you get $50", "stockSale"));
                deck.Add(new Card("Get Out of Jail Free!", "jailFree"));
                deck.Add(new Card("Go directly to Jail. Do not pass Go, do not collect $200", "jail"));
                deck.Add(new Card("Grand Opera opening. Collect $50 from each player for opening night seats", "grandOpera"));
                deck.Add(new Card("Xmas fund matures. Collect $100", "xmasFund"));
                deck.Add(new Card("Income tax refund. Collect $20", "taxRefund"));
                deck.Add(new Card("Life insurance matures. Collect $100", "lifeInsurance"));
                deck.Add(new Card("Pay hospital $100", "hospitalFees"));
                deck.Add(new Card("Pay School Tax of $150", "schoolTax"));
                deck.Add(new Card("Receive for services $25", "services"));
                deck.Add(new Card("You are assessed for street repairs. $40 per house, $115 per hotel.", "streetRepairs"));
                deck.Add(new Card("You have won second prize in a beauty contest. Collect $10", "beautyContest"));
                deck.Add(new Card("You inherit $100", "inherit100"));

                #endregion
            }
        }
    }
}
