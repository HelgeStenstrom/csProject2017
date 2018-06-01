//Wine.cs
//Helge Stenström ah7875
//2018

using System;

namespace Winecellar
{
    /// <summary>
    /// Base class for wines. 
    /// </summary>
    [Serializable]
    public class Wine
    {
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public Wine()
        {
        }

        /// <summary>
        /// Constructor with all properties
        /// </summary>
        /// <param name="name">Name of the wine</param>
        /// <param name="vintage">The year the wine was produced</param>
        /// <param name="country">Country of origin</param>
        /// <param name="type">Type of wine</param>
        /// <param name="dateAdded">Date the wine was added to the program</param>
        /// <param name="dateConsumed">Date the wine was marked as consumed</param>
        /// <param name="isConsumed">True if the wine is consumed, i.e., the bottle is empty</param>
        public Wine(string name, 
            int vintage, 
            Countries country,
            WineType type,
            DateTime dateAdded,
            DateTime dateConsumed,
            bool isConsumed)
        {
            WineName = name;
            Vintage = vintage;
            Country = country;
            WineType = type;
            DateAdded = dateAdded;
            DateConsumed = dateConsumed;
            IsConsumed = isConsumed;

        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        ///<param name="wine"></param>
        protected Wine(Wine other)
        {
            WineName = other.WineName;
            Vintage = other.Vintage;
            Country = other.Country;
            WineType = other.WineType;
            DateAdded = other.DateAdded;
            DateConsumed = other.DateConsumed;
            IsConsumed = other.IsConsumed;
        }
        #endregion Constructors

        #region Properties

        /// <summary>
        /// Name of the wine as string. Property, read and write access
        /// </summary>
        public string WineName
        {
            get;
            set;
        }

        /// <summary>
        /// The vintage (year) of the wine. Property, read and write access
        /// </summary>
        public int Vintage
        {
            get;
            set;
        }

        /// <summary>
        /// The country of origin. Property, read and write access
        /// </summary>
        public Countries Country
        {
            get;
            set;
        }

        /// <summary>
        /// The type of the wine. Property, read and write access
        /// </summary>
        public WineType WineType
        {
            get;
            set;
        }

        /// <summary>
        /// The date the wine was added to the wine cellar. Property, read and write access
        /// </summary>
        public DateTime DateAdded
        {
            get;
            set;
        }
 
        /// <summary>
        /// The date the wine was consumed. Property, read and write access.
        /// Not applicable if IsConsumed is False.
        /// </summary>
        public DateTime DateConsumed
        {
            get;
            set;
        }
        
        /// <summary>
        /// True if the wine has been consumed. Property, read and write access.
        /// Consumed wines should have a valid DateConsumed.
        /// </summary>
        public bool IsConsumed
        {
            get;
            set;
        }

        /// <summary>
        /// Strings used to fill a row in a ListView. Property, read access.
        /// </summary>
        public string[] RowStrings => new[] {
                   WineName,
                   Vintage.ToString(),
                   Country.ToString().Replace("_", " "),
                   WineType.ToString(),
                   DateColumnString
                    };
        
        /// <summary>
        /// The date column of the wine list has different contents depending on if the wine is consumed or not.
        /// Because both the wine manager and the main form treats all columns the same, we implement
        /// the column here.
        /// </summary>
        /// <returns>Date string of consumption or addition to wine cellar.</returns>
        private string DateColumnString
        {
            get
            {
                if (IsConsumed)
                    return "Drucken: " + DateConsumed.ToString(@"yyyy-MM-dd");
                return "Tillagd: " + DateAdded.ToString(@"yyyy-MM-dd");
            }
        }
        #endregion Properties

        /// <summary>
        /// Return a copy of this wine object
        /// </summary>
        /// <returns>a copy of this wine object</returns>
        public virtual Wine Clone()
        {
            return new Wine(this);
        }
    } //close class
} // close namespace