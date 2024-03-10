using MonopolyWebApp.Models;
using System.Collections.Generic;

namespace MonopolyWebApp.Data
{
    public class Space
    {
        #region Space properties

        /// <summary>
        /// Space ID
        /// </summary>
        public int SpaceID { get; set; } 

        /// <summary>
        /// public The name of the space.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// public path to the img of the space.
        /// </summary>
        public string Img { get; set; }

        /// <summary>
        /// public The property on the space. 
        /// </summary>
        public virtual Property Property { get; set; }
        public int PropertyId { get; set; }

        /// <summary>
        /// public A boolean that determines whether or not the space has a property.
        /// </summary>
        public bool HasProp {get; set;}

        /// <summary>
        /// public The amount of buildings on the space.
        /// </summary>
        public int BuildingAmount { get; set; }

        //public virtual ICollection<Property> Properties { get; set; }


        #endregion

        #region ctors

        /// <summary>
        /// default ctor
        /// </summary>
        public Space()
        {
            Name = "N/A";
            Img = "~/images/properties/40.png";
            Property = new Property();
            HasProp = false;
            BuildingAmount = 0;
        }

        /// <summary>
        /// Constructor that initializes a property space.
        /// </summary>
        /// <param name="property"></param>
        public Space(Property property)
        {
            Name=property.Name;
            Img = property.Img;
            this.Property = property;
            HasProp = true;
            BuildingAmount = 0;
        }

        /// <summary>
        /// Constructor that initializes a space that does not have a property on it.
        /// </summary>
        /// <param name="name"></param>
        public Space(string name, string img)
        {
            this.Name = name;
            this.Img = img;
            Property = new Property();
            HasProp = false;
            BuildingAmount = 0;
        }

        #endregion
    }
}
