using Microsoft.AspNetCore.SignalR;

namespace MonopolyWebApp.Models
{
    public class Property
    {
        #region Свойства собственности

        /// <summary>
        /// Property name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Buy price
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
        public bool IsMortagaged { get; set; } = false;
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

        #endregion

        /// <summary>
        /// Property ctor
        /// </summary>
        /// <param name="name">Property name</param>
        /// <param name="price">Buy price</param>
        /// <param name="rent">First rent(without houses etc)</param>
        /// <param name="rent1House"> Rent if 1 house on branch</param>
        /// <param name="rent2House"> Rent if 2 house on branch</param>
        /// <param name="rent3House"> Rent if 3 house on branch</param>
        /// <param name="rent4House"> Rent if 4 house on branch</param>
        /// <param name="rentHotel"> Rent if Hotel on branch</param>
        /// <param name="mortageValue">закладываемая стоимость</param>
        /// <param name="isMortage">Не/Заложено</param>
        /// <param name="buildingCost">Стоимость постройки</param>
        /// <param name="color">Color of property</param>
        /// <param name="owner">Owner of property</param>
        public Property(string name, int price, int rent, int rent1House, int rent2House, int rent3House,
            int rent4House, int rentHotel, int mortageValue, bool isMortagaged, int buildingCost, string color, string owner)
        {
            Name = name;
            Price = price;
            Rent = rent;
            Rent1House = rent1House;
            Rent2House = rent2House;
            Rent3House = rent3House;
            Rent4House = rent4House;
            RentHotel = rentHotel;
            MortageValue = mortageValue;
            IsMortagaged = isMortagaged;
            BuildingCost = buildingCost;
            Color = color;
            Owner = owner;
        }

    }
}
