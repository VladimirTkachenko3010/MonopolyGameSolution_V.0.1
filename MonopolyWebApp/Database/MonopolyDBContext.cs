using Microsoft.EntityFrameworkCore;
using MonopolyWebApp.Data;
using MonopolyWebApp.Models;

namespace MonopolyWebApp.Database
{
    public class MonopolyDBContext : DbContext
    {

        public MonopolyDBContext(DbContextOptions<MonopolyDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>(s =>
            {
                s.HasKey(k => k.CardId);
                s.HasData(

                #region Chance cards to db


                    new Card()
                    {
                        CardId = 1,
                        Description = "Advance to Go (collect 200$)",
                        Action = "advanceGo",
                    },
                    new Card()
                    {
                        CardId = 2,
                        Description = "Advance to Trafalgar Square(prop17). If you pass Go, collect $200",
                        Action = "advanceProp17",
                    },
                    new Card()
                    {
                        CardId = 3,
                        Description = "Advance to PallMall(prop7) If you pass Go, collect $200",
                        Action = "advanceProp7",
                    },
                    new Card()
                    {
                        CardId = 4,
                        Description = "Advance to nearest Utility",
                        Action = "advanceUtility",
                    },
                    new Card()
                    {
                        CardId = 5,
                        Description = "Advance to nearest Railroad",
                        Action = "advanceRailroad",
                    },
                    new Card()
                    {
                        CardId = 6,
                        Description = "Advance to nearest Railroad",
                        Action = "advanceRailroad",
                    },
                    new Card()
                    {
                        CardId = 7,
                        Description = "Bank pays you dividend of $50",
                        Action = "bankDividend",
                    },
                    new Card()
                    {
                        CardId = 8,
                        Description = "Get Out of Jail Free!",
                        Action = "jailFree",
                    },
                    new Card()
                    {
                        CardId = 9,
                        Description = "Go back 3 spaces",
                        Action = "goBack3",
                    },
                    new Card()
                    {
                        CardId = 10,
                        Description = "Go directly to Jail. Do not pass Go, do not collect $200",
                        Action = "jail",
                    },
                    new Card()
                    {
                        CardId = 11,
                        Description = "Make general repairs on all your property. For each house, pay $25. For each hotel, pay $100.",
                        Action = "generalRepairs",
                    },
                    new Card()
                    {
                        CardId = 12,
                        Description = "Pay Poor Tax of $15",
                        Action = "poorTax",
                    },
                    new Card()
                    {
                        CardId = 13,
                        Description = "Advance to King Cross St(prop3). If you pass Go, collect $200",
                        Action = "advanceProp3",
                    },
                    new Card()
                    {
                        CardId = 14,
                        Description = "Advance to Mayfair(prop28). If you pass Go, collect $200",
                        Action = "advanceProp28",
                    },
                    new Card()
                    {
                        CardId = 15,
                        Description = "You have been elected Chairman of the Board. Pay each player $50",
                        Action = "chairman",
                    },
                    new Card()
                    {
                        CardId = 16,
                        Description = "Your building and loan matures. Collect $150",
                        Action = "matures",
                    }
                );

                #endregion



                #region Добавление Рент - проблема с Ид

                modelBuilder.Entity<Rent>(p =>
                {
                    p.HasKey(e => e.RentID);
                    p.HasData(

                        new Rent(1, 2, 10, 30, 90, 160, 250),
                        new Rent(2, 4, 20, 60, 180, 320, 450),
                        new Rent(3, 25, 50, 100, 200, 0, 0),
                        new Rent(4, 6, 30, 90, 270, 400, 550),
                        new Rent(5, 6, 30, 90, 270, 400, 550),
                        new Rent(6, 8, 40, 100, 300, 450, 600),
                        new Rent(7, 10, 50, 150, 450, 625, 750),
                        new Rent(8, 0, 0, 0, 0, 0, 0),
                        new Rent(9, 10, 50, 150, 450, 625, 750),
                        new Rent(10, 12, 60, 180, 500, 700, 900),
                        new Rent(11, 25, 50, 100, 200, 0, 0),
                        new Rent(12, 14, 70, 200, 550, 750, 950),
                        new Rent(13, 14, 70, 200, 550, 750, 950),
                        new Rent(14, 16, 80, 220, 600, 800, 1000),
                        new Rent(15, 18, 90, 250, 700, 875, 1050),
                        new Rent(16, 18, 90, 250, 700, 875, 1050),
                        new Rent(17, 20, 100, 300, 750, 925, 1100),
                        new Rent(18, 25, 50, 100, 200, 0, 0),
                        new Rent(19, 22, 110, 330, 800, 975, 1150),
                        new Rent(20, 22, 110, 330, 800, 975, 1150),
                        new Rent(21, 0, 0, 0, 0, 0, 0),
                        new Rent(22, 24, 120, 360, 850, 1025, 1200),
                        new Rent(23, 26, 130, 390, 900, 1100, 1275),
                        new Rent(24, 26, 130, 390, 900, 1100, 1275),
                        new Rent(25, 28, 150, 450, 1000, 1200, 1400),
                        new Rent(26, 25, 50, 100, 200, 0, 0),
                        new Rent(27, 35, 175, 500, 1100, 1300, 1500),
                        new Rent(28, 50, 200, 600, 1400, 1700, 2000)

                    );
                });

                #endregion


                #region Добавление Проперти(для него нужен рентИД) - проблема с Ид

                //modelBuilder.Entity<Models.Property>(s =>
                //{
                //    s.HasKey(k => k.PropertyID);
                //    s.HasData(

                //    new Models.Property(1, "Олд Кент Роад", "~/images/properties/2.png", 60, 2, 10, 30, 90, 160, 250, 30, false, 50, "Brown", "OWNER"),
                //    new Models.Property(2, "Уайтшапель Роад", "~/images/properties/4.png", 60, 4, 20, 60, 180, 320, 450, 30, false, 50, "Brown", "OWNER"),
                //    new Models.Property(3, "Кинг Кросс Станция", "~/images/properties/6.png", 200, 25, 50, 100, 200, 0, 0, 100, false, 0, "Railroad", "OWNER"),
                //    new Models.Property(4, "Анджел, Ислингтон", "~/images/properties/7.png", 100, 6, 30, 90, 270, 400, 550, 50, false, 50, "Light Blue", "OWNER"),
                //    new Models.Property(5, "Иустон Роад", "~/images/properties/9.png", 100, 6, 30, 90, 270, 400, 550, 50, false, 50, "Light Blue", "OWNER"),
                //    new Models.Property(6, "Пентонвиль Роад", "~/images/properties/10.png", 120, 8, 40, 100, 300, 450, 600, 60, false, 50, "Light Blue", "OWNER"),
                //    new Models.Property(7, "Пэлл Мэлл", "~/images/properties/12.png", 140, 10, 50, 150, 450, 625, 750, 70, false, 100, "Pink", "OWNER"),
                //    new Models.Property(8, "Электрическая компания", "~/images/properties/13.png", 150, 0, 0, 0, 0, 0, 0, 75, false, 0, "Utility", "OWNER"),
                //    new Models.Property(9, "Уайтхолл", "~/images/properties/14.png", 140, 10, 50, 150, 450, 625, 750, 70, false, 100, "Pink", "OWNER"),
                //    new Models.Property(10,"Нортумберлэнд Авеню", "~/images/properties/15.png", 160, 12, 60, 180, 500, 700, 900, 80, false, 100, "Pink", "OWNER"),
                //    new Models.Property(11, "Марилебоне Станция", "~/images/properties/16.png", 200, 25, 50, 100, 200, 0, 0, 100, false, 0, "Railroad", "OWNER"),
                //    new Models.Property(12, "Боу Стрит", "~/images/properties/17.png", 180, 14, 70, 200, 550, 750, 950, 90, false, 100, "Orange", "OWNER"),
                //    new Models.Property(13, "Малборо стрит", "~/images/properties/19.png", 180, 14, 70, 200, 550, 750, 950, 90, false, 100, "Orange", "OWNER"),
                //    new Models.Property(14, "Вайн стрит", "~/images/properties/20.png", 200, 16, 80, 220, 600, 800, 1000, 100, false, 100, "Orange", "OWNER"),
                //    new Models.Property(15, "Стрэнд", "~/images/properties/22.png", 220, 18, 90, 250, 700, 875, 1050, 110, false, 150, "Red", "OWNER"),
                //    new Models.Property(16, "Флит Стрит", "~/images/properties/24.png", 220, 18, 90, 250, 700, 875, 1050, 110, false, 150, "Red", "OWNER"),
                //    new Models.Property(17, "Трафальгар Площадь", "~/images/properties/25.png", 240, 20, 100, 300, 750, 925, 1100, 120, false, 150, "Red", "OWNER"),
                //    new Models.Property(18, "Фенчорч Станция", "~/images/properties/26.png", 200, 25, 50, 100, 200, 0, 0, 100, false, 0, "Railroad", "OWNER"),
                //    new Models.Property(19, "Личестер Площадь", "~/images/properties/27.png", 260, 22, 110, 330, 800, 975, 1150, 130, false, 150, "Yellow", "OWNER"),
                //    new Models.Property(20, "Ковентри Стрит", "~/images/properties/28.png", 260, 22, 110, 330, 800, 975, 1150, 130, false, 150, "Yellow", "OWNER"),
                //    new Models.Property(21, "Водная Станция", "~/images/properties/29.png", 150, 0, 0, 0, 0, 0, 0, 75, false, 0, "Utility", "OWNER"),
                //    new Models.Property(22, "Пикадилли", "~/images/properties/30.png", 280, 24, 120, 360, 850, 1025, 1200, 140, false, 150, "Yellow", "OWNER"),
                //    new Models.Property(23, "Регент Стрит", "~/images/properties/32.png", 300, 26, 130, 390, 900, 1100, 1275, 150, false, 200, "Green", "OWNER"),
                //    new Models.Property(24, "Оксфорд Стрит", "~/images/properties/33.png", 300, 26, 130, 390, 900, 1100, 1275, 150, false, 200, "Green", "OWNER"),
                //    new Models.Property(25, "Бонд Стрит", "~/images/properties/35.png", 320, 28, 150, 450, 1000, 1200, 1400, 160, false, 200, "Green", "OWNER"),
                //    new Models.Property(26, "Ливерпуль Станция", "~/images/properties/36.png", 200, 25, 50, 100, 200, 0, 0, 100, false, 0, "Railroad", "OWNER"),
                //    new Models.Property(27, "Парк Лейн", "~/images/properties/38.png", 350, 35, 175, 500, 1100, 1300, 1500, 175, false, 200, "Dark Blue", "OWNER"),
                //    new Models.Property(28, "Мейфэир", "~/images/properties/40.png", 400, 50, 200, 600, 1400, 1700, 2000, 200, false, 200, "Dark Blue", "OWNER")

                //    );
                //});

                #endregion

                #region Space



                //modelBuilder.Entity<Rent>(s =>
                //{
                //    s.HasKey(k => k.RentID);
                //    s.HasData(

                //        new Rent(

                //    );
                //});


                #endregion


            });



        }

        public DbSet<Rent> Rents { get; set; }
        public DbSet<Models.Property> Properties { get; set; }
        public DbSet<Space> Spaces { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
