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

        }

        /// <param name="wine">Copy constructor</param>
        public Wine(Wine wine)
        {
            this.Name = Name;
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
        /// Prperty, read and write access
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
        public string Name
        {
            get => default(string);
            set
            {
            }
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
            bool validName = !(string.IsNullOrWhiteSpace(Name));
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
    }
}