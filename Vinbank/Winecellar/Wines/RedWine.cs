using System;

namespace Winecellar
{
    class RedWine : Wine
    {
        public RedWine(string name, 
            int vintage, 
            Countries country, 
            DateTime dateAdded, 
            DateTime dateConsumed, 
            bool isConsumed) : 
            base(name, 
                vintage, 
                country, 
                WineType.Rött, 
                dateAdded, 
                dateConsumed, 
                isConsumed) 
        {
        }

        public RedWine(RedWine other) : base(other)
        {
        }
        
        public override Wine Clone()
        {
            return new RedWine(this);
        }
    }
}
