using System;
using Winecellar;

namespace Vinbank
{
    class WhiteWine : Wine
    {
        public WhiteWine(string name, 
            int vintage, 
            Countries country, 
            DateTime dateAdded, 
            DateTime dateConsumed, 
            bool isConsumed) : 
            base(name, 
                 vintage, 
                country, 
                WineType.Vitt, 
                dateAdded, 
                dateConsumed, 
                isConsumed) 
        {
        }

        public WhiteWine(WhiteWine other) : base(other)
        {
        }

        public override Wine Clone()
        {
            return new WhiteWine(this);
        }
            
    }
}
