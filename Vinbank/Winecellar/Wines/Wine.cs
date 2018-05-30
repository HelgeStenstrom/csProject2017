//Wine.cs
//Helge Stenström ah7875
//2017-12-29
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Winecellar
{
    public class Wine
    {
        // TODO: Se till att rätt vinklass skapas när viner skapas av formulär
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public Wine()
        {
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        ///<param name="wine"></param>
        public Wine(Wine other)
        {
            this.WineName = other.WineName;
            this.Vintage = other.Vintage;
            this.Country = other.Country;
            this.WineType = other.WineType;
            this.DateAdded = other.DateAdded;
            this.DateConsumed = other.DateConsumed;
            this.IsConsumed = other.IsConsumed;
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
        public string[] RowStrings => new string[] {
                   WineName,
                   Vintage.ToString(),
                   Country.ToString().Replace("_", " "),
                   WineType.ToString(),
                   DateColumnString,
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
                else
                    return "Tillagd: " + DateAdded.ToString(@"yyyy-MM-dd");
            }
        }
        #endregion Properties

    } //close class
} // close namespace