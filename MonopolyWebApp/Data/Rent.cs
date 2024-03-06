namespace MonopolyWebApp.Data
{
    public class Rent
    {
        /// <summary>
        /// rent id
        /// </summary>
        public int RentID { get; set; }
        /// <summary>
        /// First rent(without houses etc)
        /// </summary>
        public int RentBase { get; set; }
        /// <summary>
        /// Rent if 1 house on branch
        /// </summary>
        public int RentOne{ get; set; }
        /// <summary>
        /// Rent if 2 house on branch
        /// </summary>
        public int RentTwo{ get; set; }
        /// <summary>
        /// Rent if 3 house on branch
        /// </summary>
        public int RentThree{ get; set; }
        /// <summary>
        /// Rent if 4 house on branch
        /// </summary>
        public int RentFour{ get; set; }
        /// <summary>
        /// Rent if Hotel on branch
        /// </summary>
        public int RentHotel { get; set; }


        public Rent(int rentBase, int rentOne, int rentTwo, int rentThree, int rentFour, int rentHotel)
        {
            RentBase = rentBase;
            RentOne = rentOne;
            RentTwo = rentTwo;
            RentThree = rentThree;
            RentFour = rentFour;
            RentHotel = rentHotel;
        }

    }
}
