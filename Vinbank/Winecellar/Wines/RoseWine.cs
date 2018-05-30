using System;

namespace Winecellar
{
    [Serializable]
    class RoseWine : Wine
    {
        public RoseWine(string name, 
            int vintage, 
            Countries country, 
            DateTime dateAdded, 
            DateTime dateConsumed, 
            bool isConsumed) : 
            base(name, 
                vintage, 
                country, 
                WineType.Rosé, 
                dateAdded, 
                dateConsumed, 
                isConsumed) 
        {
        }

        public RoseWine(RoseWine other) : base(other)
        {
        }
        
        public override Wine Clone()
        {
            return new RoseWine(this);
        }
    }
}
