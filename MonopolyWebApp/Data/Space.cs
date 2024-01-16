using MonopolyWebApp.Models;

namespace MonopolyWebApp.Data
{
    public class Space
    {
        #region Space properties

        /// <summary>
        /// private The name of the space.
        /// </summary>
        private string name;
        /// <summary>
        /// public The name of the space.
        /// </summary>
        public string Name { get { return name; } }

        /// <summary>
        /// private The property on the space. 
        /// </summary>
        private Property property;
        /// <summary>
        /// public The property on the space. 
        /// </summary>
        public Property Property { get { return property; } }

        /// <summary>
        /// private A boolean that determines whether or not the space has a property.
        /// </summary>
        private bool hasProp;
        /// <summary>
        /// public A boolean that determines whether or not the space has a property.
        /// </summary>
        public bool HasProp
        {
            get
            {
                return hasProp;
            }
            set
            {
                hasProp = value;
            }
        }

        /// <summary>
        /// private The amount of buildings on the space.
        /// </summary>
        private int buildingAmount;
        /// <summary>
        /// public The amount of buildings on the space.
        /// </summary>
        public int BuildingAmount {
            get
            {
                return buildingAmount;
            }
            set
            {
                buildingAmount = value;
            }
        }

        #endregion

        #region ctors

        /// <summary>
        /// default ctor
        /// </summary>
        public Space()
        {
            name = "N/A";
            property = new Property();
            hasProp = false;
            buildingAmount = 0;
        }

        /// <summary>
        /// Constructor that initializes a property space.
        /// </summary>
        /// <param name="property"></param>
        public Space(Property property)
        {
            name=property.Name;
            this.property = property;
            hasProp = true;
            buildingAmount = 0;
        }

        /// <summary>
        /// Constructor that initializes a space that does not have a property on it.
        /// </summary>
        /// <param name="name"></param>
        public Space(string name)
        {
            this.name = name;
            property = new Property();
            hasProp = false;
            buildingAmount = 0;
        }

        #endregion
    }
}
