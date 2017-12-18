using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vinbank
{
    public class WineManager
    {


        /// <summary>
        /// Property
        /// </summary>
        public List<Wine> WineList
        {
            get => default(List<Wine>);
            set
            {
            }
        }

        public Wine Wine
        {
            get => default(Wine);
            set
            {
            }
        }

        /// <returns>A list of wines yet not consumed, in the wine cellar.</returns>
        public Wine GetNonConsumed()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Add a wine to the wine cellar
        /// </summary>
        public void Add(Wine wine)
        {
            throw new System.NotImplementedException();
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
    }
}