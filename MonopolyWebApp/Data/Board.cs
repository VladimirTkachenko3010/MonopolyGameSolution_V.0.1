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
        /// An array of spaces that represent the game board.
        /// </summary>
        public Space[] spaceContainer;

        /// <summary>
        /// decks
        /// </summary>
        public DeckApp deckApp;

        public List<Card> chanceDeckList;

        public List<Card> communityChestDeckList;
        

        #endregion

        public Board() 
        {
            #region Properties

            //start
            var property1 = new Property("Олд Кент Роад", "~/images/properties/2.png", 60, 2, 10, 30, 90, 160, 250, 30, false, 50, "Brown", "OWNER");
            //Общественная казна "Community Chest"
            var property2 = new Property("Уайтшапель Роад", "~/images/properties/4.png", 60, 4, 20, 60, 180, 320, 450, 30, false, 50, "Brown", "OWNER" );
            //Налог -200 "Income Tax"
            var property3 = new Property("Кинг Кросс Станция", "~/images/properties/6.png", 200, 25, 50, 100, 200, 0, 0, 100, false, 0, "Railroad", "OWNER"); 
            var property4 = new Property("Анджел, Ислингтон", "~/images/properties/7.png", 100, 6, 30, 90, 270, 400, 550, 50, false, 50, "Light Blue", "OWNER");
            //Chance
            var property5 = new Property("Иустон Роад", "~/images/properties/9.png", 100, 6, 30, 90, 270, 400, 550, 50, false, 50, "Light Blue", "OWNER");
            var property6 = new Property("Пентонвиль Роад", "~/images/properties/10.png", 120,8, 40, 100, 300, 450, 600, 60, false, 50, "Light Blue", "OWNER");
            //Jail
            var property7 = new Property("Пэлл Мэлл", "~/images/properties/12.png", 140, 10, 50, 150, 450, 625, 750, 70, false, 100, "Pink", "OWNER");
            var property8 = new Property("Электрическая компания", "~/images/properties/13.png", 150, 0, 0, 0, 0, 0, 0, 75,  false, 0, "Utility", "OWNER");  
            var property9 = new Property("Уайтхолл", "~/images/properties/14.png", 140, 10, 50, 150, 450, 625, 750, 70, false, 100, "Pink", "OWNER");
            var property10 = new Property("Нортумберлэнд Авеню", "~/images/properties/15.png", 160, 12, 60, 180, 500, 700, 900, 80, false, 100, "Pink", "OWNER");
            var property11 = new Property("Марилебоне Станция", "~/images/properties/16.png", 200, 25, 50, 100, 200, 0, 0, 100, false, 0, "Railroad", "OWNER");
            var property12 = new Property("Боу Стрит", "~/images/properties/17.png", 180, 14, 70, 200, 550, 750, 950, 90, false, 100, "Orange", "OWNER");
            //Общественная казна "Community Chest"
            var property13 = new Property("Малборо стрит", "~/images/properties/19.png", 180,14, 70, 200, 550, 750, 950, 90, false, 100, "Orange", "OWNER");
            var property14 = new Property("Вайн стрит", "~/images/properties/20.png", 200,16, 80, 220, 600, 800, 1000, 100, false, 100, "Orange", "OWNER");
            //"Free Parking"
            var property15 = new Property("Стрэнд", "~/images/properties/22.png", 220,18, 90, 250, 700, 875, 1050, 110, false, 150, "Red", "OWNER");
            //Chance
            var property16 = new Property("Флит Стрит", "~/images/properties/24.png", 220,18, 90, 250, 700, 875, 1050, 110, false, 150, "Red", "OWNER");
            var property17 = new Property("Трафальгар Площадь", "~/images/properties/25.png", 240, 20, 100, 300, 750, 925, 1100, 120, false, 150, "Red", "OWNER");
            var property18 = new Property("Фенчорч Станция", "~/images/properties/26.png", 200, 25, 50, 100, 200, 0, 0, 100, false, 0, "Railroad", "OWNER");
            var property19 = new Property("Личестер Площадь", "~/images/properties/27.png", 260, 22, 110, 330, 800, 975, 1150, 130, false, 150,  "Yellow", "OWNER");
            var property20 = new Property("Ковентри Стрит", "~/images/properties/28.png", 260, 22, 110, 330, 800, 975, 1150, 130, false, 150, "Yellow", "OWNER");
            var property21 = new Property("Водная Станция", "~/images/properties/29.png", 150, 0, 0, 0, 0, 0, 0, 75, false, 0, "Utility", "OWNER"); 
            var property22 = new Property("Пикадилли", "~/images/properties/30.png", 280, 24, 120, 360, 850, 1025, 1200, 140, false, 150, "Yellow", "OWNER");
            //Jail
            var property23 = new Property("Регент Стрит", "~/images/properties/32.png", 300, 26, 130, 390, 900, 1100, 1275, 150, false, 200, "Green", "OWNER");
            var property24 = new Property("Оксфорд Стрит", "~/images/properties/33.png", 300, 26, 130, 390, 900, 1100, 1275, 150, false, 200, "Green", "OWNER");
            //Общественная казна "Community Chest"
            var property25 = new Property("Бонд Стрит", "~/images/properties/35.png", 320,28, 150, 450, 1000, 1200, 1400, 160, false, 200, "Green", "OWNER");
            var property26 = new Property("Ливерпуль Станция", "~/images/properties/36.png", 200, 25, 50, 100, 200, 0, 0, 100, false, 0, "Railroad", "OWNER");
            //Chance
            var property27 = new Property("Парк Лейн", "~/images/properties/38.png", 350,35, 175, 500, 1100, 1300, 1500, 175, false, 200, "Dark Blue", "OWNER");
            //Налог -100 "Luxury Tax"
            var property28 = new Property("Мейфэир", "~/images/properties/40.png", 400,50, 200, 600, 1400, 1700, 2000, 200, false, 200, "Dark Blue", "OWNER");

            // Put those properties into the spaceContainer, along with spaces that are not properties.
            spaceContainer = new Space[40] { new Space("GO", "~/images/properties/1.png"), new Space(property1), new Space("Community Chest", "~/images/properties/3.png"),
                new Space(property2), new Space("Income Tax", "~/images/properties/5.png"), new Space(property3), new Space(property4), new Space("Chance", "~/images/properties/8.png"),
                new Space(property5), new Space(property6), new Space("Just Visiting", "~/images/properties/11.png"), new Space(property7), new Space(property8),
                new Space(property9), new Space(property10), new Space(property11), new Space(property12), new Space("Community Chest", "~/images/properties/18.png"),
                new Space(property13), new Space(property14), new Space("Free Parking", "~/images/properties/21.png"), new Space(property15), new Space("Chance", "~/images/properties/23.png"),
                new Space(property16), new Space(property17), new Space(property18), new Space(property19), new Space(property20),
                new Space(property21), new Space(property22), new Space("Go To Jail", "~/images/properties/31.png"), new Space(property23), new Space(property24),
                new Space("Community Chest", "~/images/properties/34.png"), new Space(property25), new Space(property26), new Space("Chance", "~/images/properties/37.png"), new Space(property27),
                new Space("Luxury Tax", "~/images/properties/39.png"), new Space(property28) };
            #endregion

            #region Shuffle chance and community decks
            chanceDeckList = new List<Card>();
            var chanceDeck = new Deck(chanceDeckList, "Chance");
            communityChestDeckList = new List<Card>();
            var communityChestDeck = new Deck(communityChestDeckList, "Community");

            deckApp = new DeckApp();
            deckApp.ShuffleDeck(chanceDeckList);
            deckApp.ShuffleDeck(communityChestDeckList);

            #endregion
        }
    }
}
