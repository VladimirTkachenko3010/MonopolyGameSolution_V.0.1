using Microsoft.AspNetCore.SignalR;
using MonopolyWebApp.Data;
using System.Drawing;
using System.Threading;
using System.Xml.Linq;

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
        /// Img of prop
        /// </summary>
        public string Img { get; set; }

        /// <summary>
        /// Buy price
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Rent info
        /// </summary>
        public Rent Rent { get; set; }

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
        /// <param name="img">Property img</param>
        /// <param name="price">Buy price</param>
        /// <param name="rentBase">First rent(without houses etc)</param>
        /// <param name="rentOne"> Rent if 1 house on branch</param>
        /// <param name="rentTwo"> Rent if 2 house on branch</param>
        /// <param name="rentThree"> Rent if 3 house on branch</param>
        /// <param name="rentFour"> Rent if 4 house on branch</param>
        /// <param name="rentHotel"> Rent if Hotel on branch</param>
        /// <param name="mortageValue">закладываемая стоимость</param>
        /// <param name="isMortage">Не/Заложено</param>
        /// <param name="buildingCost">Стоимость постройки</param>
        /// <param name="color">Color of property</param>
        /// <param name="owner">Owner of property</param>
        public Property(string name, string img, int price, int rentBase, int rentOne, int rentTwo, int rentThree,
            int rentFour, int rentHotel, int mortageValue, bool isMortagaged, int buildingCost, string color, string owner)
        {
            Name = name;
            Img = img;
            Price = price;
            this.Rent = new Rent(rentBase, rentOne, rentTwo, rentThree, rentFour, rentHotel);
            MortageValue = mortageValue;
            IsMortagaged = isMortagaged;
            BuildingCost = buildingCost;
            Color = color;
            Owner = owner;
        }

        /// <summary>
        /// default ctor
        /// </summary>
        public Property()
        {
            Name = "N/A";
            Img = "N/A";
            Price = 0;
            this.Rent = new Rent(0, 0, 0, 0, 0, 0);
            MortageValue = 0;
            IsMortagaged = false;
            BuildingCost = 0;
            Color = "N/A";
            Owner = "N/A";
        }

    }
}
