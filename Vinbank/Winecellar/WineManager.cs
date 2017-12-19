using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Winecellar
{
    public class WineManager
    {

        private List<Wine> wines; //declare list of wine


        /// <summary>
        /// Property returning number of wines
        /// Only read access
        /// </summary>
        public int WineCount
        {
            get => wines.Count;
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public WineManager()
        {
            wines = new List<Wine>(); //create list of wines
        }

        /// <summary>
        /// Add a wine to the wine cellar
        /// </summary>
        public void Add(Wine wineIn)
        {
            Wine wineObj = new Wine(wineIn); //declare and create  wine object
            wines.Add(wineObj);
        }
        
        /// <summary>
        /// Remove wine from wine cellar
        /// </summary>
        /// <param name="index"></param>
        public bool Remove(int index)
        {
            if (!CheckIndex(index))
                return false;
            else
            {
                wines.RemoveAt(index);
                return true;
            }
        }

        /// <summary>
        /// checks if index is valid
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
        /// Mark the wine pointed to by the index, as consumed.
        /// </summary>
        public void Consume(int index)
       {
            throw new System.NotImplementedException();
        }


        /// <summary>
        /// Change the details of an existing wine
        /// </summary>
        /// <param name="index">Points to the wine to edit</param>
        public void Edit(int index)
        {
            throw new System.NotImplementedException();
        }

        /// <returns>A list of wines yet not consumed, in the wine cellar.</returns>
        public Wine GetNonConsumed()
        {
            throw new System.NotImplementedException();
        }

        public List<String[]> WinesAsRows
        {
            get
            {
                List<string[]> listOfCellsForOneRow = new List<string[]>();
                foreach (var wine in wines)
                {
                    // TODO: fyll på med fakta från ett vin istället.
                    listOfCellsForOneRow.Add(wine.RowStrings);
                }
                return listOfCellsForOneRow;
            }
        }

    }
}