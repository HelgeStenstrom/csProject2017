using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vinbank
{
    public class WineManager
    {

        private List<Wine> wines; //declare list of wine

        ///// <summary>
        ///// Property
        ///// </summary>
        //public List<Wine> WineList
        //{
        //    get => default(List<Wine>);
        //    set
        //    {
        //    }
        //}

        //public Wine Wine
        //{
        //    get => default(Wine);
        //    set
        //    {
        //    }
        //}

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
        /// Mark the wine pointed to by the index, as consumed.
        /// </summary>
        public void Consume(int index)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int index)
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

    }
}