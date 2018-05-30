﻿using System;
using Winecellar;

namespace Vinbank
{
    class SweetWine : Wine
    {
        public SweetWine(string name, 
            int vintage, 
            Countries country, 
            DateTime dateAdded, 
            DateTime dateConsumed, 
            bool isConsumed) : 
            base(name, 
                vintage, 
                country, 
                WineType.Sött, 
                dateAdded, 
                dateConsumed, 
                isConsumed) 
        {
        }

        public SweetWine(SweetWine other) : base(other)
        {
        }
        
        public override Wine Clone()
        {
            return new SweetWine(this);
        }
    }
}
