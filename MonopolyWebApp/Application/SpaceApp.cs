using MonopolyWebApp.Data;
using MonopolyWebApp.Models;

namespace MonopolyWebApp.Application
{
    public class SpaceApp
    {
        #region funcs

        /// <summary>
        /// Gets the property on the space.
        /// </summary>
        /// <returns></returns>
        public Property GetProperty(Space space) { return space.Property; }

        public int CalcRent(Space space)
        {
            switch (space.BuildingAmount)
            {
                case 1:
                    return space.Property.Rent.RentOne;
                case 2:
                    return space.Property.Rent.RentTwo;
                case 3:
                    return space.Property.Rent.RentThree;
                case 4:
                    return space.Property.Rent.RentFour;
                case 5:
                    return space.Property.Rent.RentHotel;
                default:
                    return space.Property.Rent.RentBase;
            }
        }

        public void AddBuilding(Space space)
        {
            space.BuildingAmount++;
        }

        public void RemoveBuilding(Space space)
        {
            space.BuildingAmount--;
        }

        #endregion
    }
}
