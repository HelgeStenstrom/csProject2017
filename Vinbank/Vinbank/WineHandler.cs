using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vinbank
{
    public class WineCellar
    {
        public List<Wine> WineList
        {
            get => default(List<Wine>);
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
    }
}