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

        #endregion

        public Board() 
        {
            #region Properties

            //start
            var property1 = new Property("Олд Кент Роад", 60, 2, 10, 30, 90, 160, 250, 30, false, 50, "Brown", "OWNER");
            //Общественная казна
            var property2 = new Property("Уайтшапель Роад", 60, 4, 20, 60, 180, 320, 450, 30, false, 50, "Brown", "OWNER" );
            //Налог -200
            var property3 = new Property("Кинг Кросс Станция", 200, 25, 50, 100, 200, 0, 0, 100, false, 0, "Railroad", "OWNER"); 
            var property4 = new Property("Анджел, Ислингтон", 100, 6, 30, 90, 270, 400, 550, 50, false, 50, "Light Blue", "OWNER");
            //Chance
            var property5 = new Property("Иустон Роад", 100, 6, 30, 90, 270, 400, 550, 50, false, 50, "Light Blue", "OWNER");
            var property6 = new Property("Пентонвиль Роад", 120,8, 40, 100, 300, 450, 600, 60, false, 50, "Light Blue", "OWNER");
            //Jail
            var property7 = new Property("Пэлл Мэлл", 140, 10, 50, 150, 450, 625, 750, 70, false, 100, "Pink", "OWNER");
            var property8 = new Property("Электрическая компания", 150, 0, 0, 0, 0, 0, 0, 75,  false, 0, "Utility", "OWNER");  
            var property9 = new Property("Уайтхолл", 140, 10, 50, 150, 450, 625, 750, 70, false, 100, "Pink", "OWNER");
            var property10 = new Property("Нортумберлэнд Авеню", 160, 12, 60, 180, 500, 700, 900, 80, false, 100, "Pink", "OWNER");
            var property11 = new Property("Марилебоне Станция", 200, 25, 50, 100, 200, 0, 0, 100, false, 0, "Railroad", "OWNER");
            var property12 = new Property("Боу Стрит", 180, 14, 70, 200, 550, 750, 950, 90, false, 100, "Orange", "OWNER");
            //Общественная казна
            var property13 = new Property("Малборо стрит", 180,14, 70, 200, 550, 750, 950, 90, false, 100, "Orange", "OWNER");
            var property14 = new Property("Вайн стрит", 200,16, 80, 220, 600, 800, 1000, 100, false, 100, "Orange", "OWNER");
            //Car
            var property15 = new Property("Стрэнд", 220,18, 90, 250, 700, 875, 1050, 110, false, 150, "Red", "OWNER");
            //Chance
            var property16 = new Property("Флит Стрит", 220,18, 90, 250, 700, 875, 1050, 110, false, 150, "Red", "OWNER");
            var property17 = new Property("Трафальгар Площадь", 240, 20, 100, 300, 750, 925, 1100, 120, false, 150, "Red", "OWNER");
            var property18 = new Property("Фенчорч Станция", 200, 25, 50, 100, 200, 0, 0, 100, false, 0, "Railroad", "OWNER");
            var property19 = new Property("Личестер Площадь", 260, 22, 110, 330, 800, 975, 1150, 130, false, 150,  "Yellow", "OWNER");
            var property20 = new Property("Ковентри Стрит", 260, 22, 110, 330, 800, 975, 1150, 130, false, 150, "Yellow", "OWNER");
            var property21 = new Property("Водная Станция", 150, 0, 0, 0, 0, 0, 0, 75, false, 0, "Utility", "OWNER"); 
            var property22 = new Property("Пикадилли", 280, 24, 120, 360, 850, 1025, 1200, 140, false, 150, "Yellow", "OWNER");
            //Jail
            var property23 = new Property("Регент Стрит", 300, 26, 130, 390, 900, 1100, 1275, 150, false, 200, "Green", "OWNER");
            var property24 = new Property("Оксфорд Стрит", 300, 26, 130, 390, 900, 1100, 1275, 150, false, 200, "Green", "OWNER");
            //Общественная казна
            var property25 = new Property("Бонд Стрит", 320,28, 150, 450, 1000, 1200, 1400, 160, false, 200, "Green", "OWNER");
            var property26 = new Property("Ливерпуль Станция", 200, 25, 50, 100, 200, 0, 0, 100, false, 0, "Railroad", "OWNER");
            //Chance
            var property27 = new Property("Парк Лейн", 350,35, 175, 500, 1100, 1300, 1500, 175, false, 200, "Dark Blue", "OWNER");
            //Налог -100
            var property28 = new Property("Мейфэир", 400,50, 200, 600, 1400, 1700, 2000, 200, false, 200, "Dark Blue", "OWNER");

            #endregion

        }
    }
}
