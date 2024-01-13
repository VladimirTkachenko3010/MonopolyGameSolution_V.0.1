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
            Property property1 = new Property("Олд Кент Роад", 60, 2, 10, 30, 90, 160, 250, 30, false, 50, "Brown", "OWNER");
            //Общественная казна
            Property property2 = new Property("Уайтшапель Роад",60 );
            //Налог -200
            Property property3 = new Property("Кинг Кросс Станция", 200 );
            Property property4 = new Property("Анджел, Ислингтон", 100);
            //Chance
            Property property5 = new Property("Иустон Роад", 100);
            Property property6 = new Property("Пентонвиль Роад",120 );
            //Jail
            Property property7 = new Property("Пэлл Мэлл", 140);
            Property property8 = new Property("Электрическая компания", 150);
            Property property9 = new Property("Уайтхолл", 140 );
            Property property10 = new Property("Нортумберлэнд Авеню", 160);
            Property property11 = new Property("Марилебоне Станция", 200);
            Property property12 = new Property("Боу Стрит", 180 );
            //Общественная казна
            Property property13 = new Property("Малборо стрит", 180);
            Property property14 = new Property("Вайн стрит", 200);
            //Car
            Property property15 = new Property("Стрэнд", 220);
            //Chance
            Property property16 = new Property("Флит Стрит", 220);
            Property property17= new Property("Трафальгар Площадь",240 );
            Property property18 = new Property("Фенчорч Станция", 200 );
            Property property19 = new Property("Личестер Площадь", 260);
            Property property20 = new Property("Ковентри Стрит",260 );
            Property property21 = new Property("Водная Станция", 150);
            Property property22 = new Property("Пикадилли", 280);
            //Jail
            Property property23 = new Property("Регент Стрит", 300);
            Property property24 = new Property("Оксфорд Стрит", 300);
            //Общественная казна
            Property property25 = new Property("Бонд Стрит", 320);
            Property property26 = new Property("Ливерпуль Станция", 200);
            //Chance
            Property property27 = new Property("Парк Лейн",350 );
            //Налог -100
            Property property28 = new Property("Мейфэир", 400);


        }
    }
}
