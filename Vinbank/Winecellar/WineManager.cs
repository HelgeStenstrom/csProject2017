﻿//WineManager.cs
//Ann-Marie Bergström ai2436
//2017-12-29

using System;
using System.Collections.Generic;

namespace Winecellar
{
    public class WineManager
    {
        #region Fields
        private List<Wine> wines; //declare list of wine
        public event EventHandler<WineEventArgs> WineChanged_handlers;
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
            Wine wineObj = wineIn.Clone();  //declare and create wine object
            wines.Add(wineObj);
            
            OnWineChangedSender("Adding wine");
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
                OnWineChangedSender("Removing wine");
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
                OnWineChangedSender("Changing wine");
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
                return wines[index].Clone();
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

        /// <summary>
        /// clear list
        /// </summary>
        public void ClearList()
        {
            wines.Clear();
        }

        #region serialize functions
        public void BinarySerialize(string binFileName)
        {
            Serializer.Serialize(binFileName, wines);
        }

        public void BinaryDeSerialize(string binFileName)
        {
            wines = Serializer.DeSerialize<List<Wine>>(binFileName);
        }
        #endregion serialize functions

        public void OnWineChangedSender(string message)
        {
            if (WineChanged_handlers != null)
            {
                WineChanged_handlers(this, new WineEventArgs(){Interesting = message, When = DateTime.Now});                
            }
        }
        
        #endregion Methods
    }
}