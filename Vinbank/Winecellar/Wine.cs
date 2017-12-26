using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Winecellar
{
    public class Wine
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Wine()
        {
            // TODO: Kom ihåg att när denna används, är inte Wine-objektet fullständigt. Det måste få data.
        }


        /// <summary>
        /// Copy constructor
        /// </summary>
        ///<param name="wine"></param>
        public Wine(Wine other)
        {
            this.WineName = other.WineName;
            this.Vintage = other.Vintage;
            this.WineType = other.WineType;
            this.DateAdded = other.DateAdded;
            this.DateConsumed = other.DateConsumed;
            this.IsConsumed = other.IsConsumed;
            this.Country = other.Country;
            // TODO: Behövs ytterligare någon del i Wine copy constructor?
        }


        /// <summary>
        /// Property, read and write access
        /// </summary>
        public string WineName
        {
            get;
            set;
        }



        /// <summary>
        /// Property, read and write access
        /// </summary>
        public int Vintage
        {
            get;
            set;
        }

        /// <summary>
        /// Property, read and write access
        /// </summary>
        public Countries Country
        {
            get;
            set;
        }

        /// <summary>
        /// Property, read and write access
        /// </summary>
        public WineType WineType
        {
            get;
            set;
        }

        /// <summary>
        /// Property, read and write access
        /// </summary>
        public DateTime DateAdded
        {
            get;
            set;
        }
        /// <summary>
        /// Property, read and write access
        /// </summary>
        public DateTime DateConsumed
        {
            get;
            set;
        }
        
        /// <summary>
        /// Property, read and write access
        /// </summary>
        public bool IsConsumed
        {
            get;
            set;
        }

        /// <summary> 
        /// Delete underscore char from selected country
        /// </summary>
        /// <returns>Country name without underscore char</returns>
        private string GetCountryString()
        {
            string strCountry = Country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }

        /// <summary>
        /// Strings used to fill a row in a ListView.
        /// </summary>
        public string[] RowStrings => new string[] {
                   WineName,
                   Vintage.ToString(),
                   Country.ToString(),
                   WineType.ToString(),
                   DateColumnString(),
                    };

        /// <summary>
        /// The date column of the wine list has different contents depending on if the wine is consumed or not.
        /// Because both the wine manager and the main form treats all columns the same, we implement
        /// the column here.
        /// </summary>
        /// <returns>Date string of consumption or addition to wine cellar.</returns>
        private string DateColumnString()
        {
            if (IsConsumed)
                return "Drucken: " + DateConsumed.ToString(@"yyyy-MM-dd");
            else
                return "Tillagd: " + DateAdded.ToString(@"yyyy-MM-dd");
        }

    } //close class
} // close namespace