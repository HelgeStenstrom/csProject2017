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

        public Wine(string name, WineType wineType, bool isConsumed)
        {
            this.WineName = name;
            this.WineType = wineType;
            this.IsConsumed = isConsumed;
            // TODO: Gör fullständig. Alla fields ska ha anropsparameterar.        
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
            // TODO: Fyll på med fakta, matchande kolumnerna i MainForm.
                   WineName,
                   Vintage.ToString(),
                   Country.ToString(),
                   WineType.ToString(),
                   DateColumnString(),
                    };

        private string DateColumnString()
        {
            if (markedAsConsumed())
                return "Drucken: " + DateConsumed.ToString(@"yyyy-MM-dd");
            else
                return "Tillagd: " + DateAdded.ToString(@"yyyy-MM-dd");
        }

        private bool markedAsConsumed()
        {
            return (DateConsumed > new DateTime(1900, 1, 1));
        }


    } //close class
} // close namespace