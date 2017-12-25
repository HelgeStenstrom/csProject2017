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

        /// <param name="wine">Copy constructor</param>
        public Wine(Wine other)
        {
            this.WineName = other.WineName;
            this.Vintage = other.Vintage;
            // TODO: Copy constructorn behöver fler delar.
        }

        /// <summary>
        /// Property, read and write access
        /// </summary>
        public WineType WineType
        {
            get => default(int);
            set
            {
            }
        }

        /// <summary>
        /// Property, read and write access
        /// </summary>
        public CharacterTypes CharacterType
        {
            get => default(CharacterTypes);
            set
            {
            }
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
        public DateTime DateAdded
        {
            get => default(DateTime);
            set
            {
            }
        }

        /// <summary>
        /// Property, read and write access
        /// </summary>
        public bool IsConsumed
        {
            get => default(bool);
            set
            {
            }
        }

        /// <summary>
        /// Property, read and write access
        /// </summary>
        public int Vintage
        {
            get => default(int);
            set
            {
            }
        }

        /// <summary>
        /// Property, read and write access
        /// </summary>
        public CharacterTypes CharacterTypes
        {
            get => default(CharacterTypes);
            set
            {
            }
        }



        /// <summary>
        /// Check if input is valid.
        /// </summary>
        /// <returns>True or false</returns>
        public bool Checkdata()
        {
            bool validName = !(string.IsNullOrWhiteSpace(WineName));
            return (validName);
        }


        /// <summary>
        /// Method,   
        /// </summary>
            public void Consume()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Method,  
        /// </summary>
        public void Unconsume()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Strings used to fill a row in a ListView.
        /// </summary>
        public string[] RowStrings => new string[] {
            // TODO: Fyll på med fakta, matchande kolumnerna i MainForm.
                   WineName,
                   "annat fakta"
                    };


    }
}