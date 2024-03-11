using System.Collections.Generic;
using System.Linq;
using MonopolyWebApp.Data;

namespace MonopolyWebApp.Database
{
    public class MonopolyInitializer
    {
        public static void Initialize(MonopolyDBContext context, List<Space> spaceContainer)
        {
            context.Database.EnsureCreated();

            // Проверяем, есть ли уже данные в базе
            if (!context.Spaces.Any())
            {
                // Добавляем объекты из spaceContainer в базу данных
                context.Spaces.AddRange(GetSpaces());
                context.SaveChanges();
            }
        }
        private static List<Space> GetSpaces()
        {
            var spaceContainer = new List<Space>();
            //spaceContainer.AddRange(new Space());
            return spaceContainer;
        }
    }
}
