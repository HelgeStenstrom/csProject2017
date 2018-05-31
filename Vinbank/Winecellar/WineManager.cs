//WineManager.cs
//Ann-Marie Bergström ai2436
//2018

using System;
using System.Collections.Generic;
using System.Linq;

namespace Winecellar
{
    /// <summary>
    /// Handles the list of wines in this program
    /// </summary>
    public class WineManager
    {
        #region Fields
        private List<Wine> wines; //declare list of wine
        
        /// <summary>
        /// Events that are sent when wines are added, changed or removed from the list.
        /// </summary>
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

        /// <summary>
        /// The count of empty bottles in the list (bottles that have been consumed)
        /// </summary>
        private int EmptyBottles => wines.Count(wine => wine.IsConsumed);

        /// <summary>
        /// The count of full bottles in the list.
        /// </summary>
        private int FullBottles => wines.Count(wine => !wine.IsConsumed);

        /// <summary>
        /// The count of full bottles of white wine in the list.
        /// </summary>
        private int FullWhites => wines.Count(wine => !wine.IsConsumed && (wine is WhiteWine));

        /// <summary>
        /// The count of full bottles of red wine in the list. Traditional implementation.
        /// </summary>
        private int FullReds
        {
            get
            {
                int count = 0;
                foreach (var wine in wines)
                {
                    if (!wine.IsConsumed && (wine is RedWine))
                    {
                        count++;
                    }
                }

                return count;
            }
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
        /// <param name="wine">Wine to replace the wine at the index</param>
        /// <param name="index">Index of the wine to be replaced</param>
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
        private bool CheckIndex(int index)
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
        /// <summary>
        /// Serialize the wine manager into a binary file
        /// </summary>
        /// <param name="binFileName">name of the file to save to</param>
        public void BinarySerialize(string binFileName)
        {
            Serializer.Serialize(binFileName, wines);
        }

        /// <summary>
        /// Read in a previously saved file with wine manager data. Replaces the current content of the wine manager. 
        /// </summary>
        /// <param name="binFileName"></param>
        public void BinaryDeSerialize(string binFileName)
        {
            wines = Serializer.DeSerialize<List<Wine>>(binFileName);
        }
        #endregion serialize functions

        /// <summary>
        /// Called to send an event containing a text message.
        /// </summary>
        /// <param name="message">The message to send</param>
        private void OnWineChangedSender(string message)
        {
            if (WineChanged_handlers != null)
            {
                var msg = $"Det finns {WineCount} flaskor vin i källaren, varav {FullBottles} är fulla, varav {FullReds} är röda.";
                WineChanged_handlers(this, new WineEventArgs(){Message = msg, When = DateTime.Now});                
            }
        }


        #endregion Methods
    }
}