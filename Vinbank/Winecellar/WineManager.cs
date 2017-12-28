//WineManager.cs
//Ann-Marie Bergström ai2436
//2017-12-29

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Winecellar
{
    public class WineManager
    {
        #region Fields
        private List<Wine> wines; //declare list of wine
        #endregion Fields

        #region Properties
        /// <summary>
        /// Property returning number of wines
        /// Only read access
        /// </summary>
        public int WineCount
        {
            get => wines.Count;
        }
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public WineManager()
        {
            wines = new List<Wine>(); //create list of wines
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Add a wine to the wine cellar
        /// </summary>
        /// <param name="wineIn"></param>
        public void AddWine(Wine wineIn)
        {
            Wine wineObj = new Wine(wineIn); //declare and create wine object
            wines.Add(wineObj);
        }
        
        /// <summary>
        /// Remove wine from wine cellar
        /// </summary>
        /// <param name="index"></param>
        public bool RemoveWine(int index)
        {
            if (CheckIndex(index))
            {
                 wines.RemoveAt(index);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Change an existing wine
        /// </summary>
        /// <param name="index"></param>
        public bool ChangeWine(Wine wine, int index)
        {
            if (CheckIndex(index))
            {
                wines[index] = wine;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Get the details of an existing wine
        /// </summary>
        /// <param name="index"></param>
        public Wine GetWine(int index)
        {
            if (CheckIndex(index))
                return new Wine(wines[index]);
            else throw new IndexOutOfRangeException();
        }

        /// <summary>
        /// Check if index is valid
        /// </summary>
        /// <param name="index"></param>
        public bool CheckIndex(int index)
        {
            if (index > -1 && index < WineCount)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Construct texts for the wine table that is used in the MainForm. 
        /// One list item per wine, each item being a string array of table cells.
        /// </summary>
        public List<String[]> WinesAsRows
        {
            get
            {
                List<string[]> listOfCellsForOneRow = new List<string[]>();
                foreach (var wine in wines)
                {
                    listOfCellsForOneRow.Add(wine.RowStrings);
                }
                return listOfCellsForOneRow;
            }
        }
        #endregion Methods
    }
}