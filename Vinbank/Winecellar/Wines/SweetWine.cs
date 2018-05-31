//SweetWine.cs
//Helge Stenström ah7875
//2018
using System;

namespace Winecellar
{
    [Serializable]
    class SweetWine : Wine
    {
        /// <summary>
        /// Constructor with all properties
        /// </summary>
        /// <param name="name">Name of the wine</param>
        /// <param name="vintage">The year the wine was produced</param>
        /// <param name="country">Country of origin</param>
        /// <param name="dateAdded">Date the wine was added to the program</param>
        /// <param name="dateConsumed">Date the wine was marked as consumed</param>
        /// <param name="isConsumed">True if the wine is consumed, i.e., the bottle is empty</param>
        public SweetWine(string name, 
            int vintage, 
            Countries country, 
            DateTime dateAdded, 
            DateTime dateConsumed, 
            bool isConsumed) : 
            base(name, 
                vintage, 
                country, 
                WineType.Sött, 
                dateAdded, 
                dateConsumed, 
                isConsumed) 
        {
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other">the wine to be copied</param>
        public SweetWine(SweetWine other) : base(other)
        {
        }

        /// <summary>
        /// Return a copy of this wine object
        /// </summary>
        /// <returns>a copy of this wine object</returns>
        public override Wine Clone()
        {
            return new SweetWine(this);
        }
    }
}
