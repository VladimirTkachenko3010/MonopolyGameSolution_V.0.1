using MonopolyWebApp.Models;

namespace MonopolyWebApp.Data
{
    public class Space
    {
        /// <summary>
        /// private The name of the space.
        /// </summary>
        private string name;
        /// <summary>
        /// public The name of the space.
        /// </summary>
        public string Name { get { return name; } }
        /// <summary>
        /// The property on the space. 
        /// </summary>
        private Property property { get; set; }
        /// <summary>
        /// A boolean that determines whether or not the space has a property.
        /// </summary>
        private bool HasProp { get; set; }
        /// <summary>
        /// The amount of buildings on the space.
        /// </summary>
        private int BuildingAmount { get; set; }

        /// <summary>
        /// default ctor
        /// </summary>
        public Space()
        {
            name = "N/A";
            property = new Property();
            HasProp = false;
            BuildingAmount = 0;
        }

        /// <summary>
        /// Constructor that initializes a property space.
        /// </summary>
        /// <param name="property"></param>
        public Space(Property property)
        {
            name=property.Name;
            this.property = property;
            HasProp = true;
            BuildingAmount = 0;
        }

        /// <summary>
        /// Constructor that initializes a space that does not have a property on it.
        /// </summary>
        /// <param name="name"></param>
        public Space(string name)
        {
            this.name = name;
            property = new Property();
            HasProp = false;
            BuildingAmount = 0;
        }

        /// <summary>
        /// Gets the property on the space.
        /// </summary>
        /// <returns></returns>
        public Property GetProperty() { return property; }

        public int CalcRent()
        {
            switch(BuildingAmount)
            {
                case 1:
                    return property.Rent1House;
                case 2:
                    return property.Rent2House;
                case 3:
                    return property.Rent3House;
                case 4:
                    return property.Rent4House;
                case 5:
                    return property.RentHotel;
                default:
                    return property.Rent;
            }
        }

        public void AddBuilding()
        {
            BuildingAmount++;
        }

        public void RemoveBuilding()
        { 
            BuildingAmount--;
        }
    }
}
