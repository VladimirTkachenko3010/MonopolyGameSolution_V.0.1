using Microsoft.AspNetCore.SignalR;

namespace MonopolyWebApp.Models
{
    public class Property
    {
        /// <summary>
        /// Property name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// First buy price
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// First rent(without houses etc)
        /// </summary>
        public int Rent { get; set; }
        /// <summary>
        /// Rent if 1 house on branch
        /// </summary>
        public int Rent1House { get; set; }
        /// <summary>
        /// Rent if 2 house on branch
        /// </summary>
        public int Rent2House { get; set; }
        /// <summary>
        /// Rent if 3 house on branch
        /// </summary>
        public int Rent3House { get; set; }
        /// <summary>
        /// Rent if 4 house on branch
        /// </summary>
        public int Rent4House { get; set; }
        /// <summary>
        /// Rent if Hotel on branch
        /// </summary>
        public int RentHotel { get; set; }
        /// <summary>
        /// закладывание
        /// </summary>
        public int MortageValue { get; set;}
        /// <summary>
        /// Не/Заложено
        /// </summary>
        public bool IsMortage { get; set; } = false;
        /// <summary>
        /// Стоимость постройки
        /// </summary>
        public int BuildingCost { get; set; }
        /// <summary>
        /// Color of property
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Owner of property
        /// </summary>
        public string Owner { get; set; }


    }
}
