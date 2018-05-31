//WineFactory.cs
//Helge Stenström ah7875
//2018
using System;
using Winecellar;

namespace Winecellar
{
    /// <summary>
    /// Creates wines of the wanted type
    /// </summary>
    public static class WineFactory
    {
       /// <summary>
       /// factory method, similar to a constructor, but creates different classes depending on the arguments.
       /// </summary>
       /// <param name="type">Red, white, rosé or sweet,</param>
       /// <param name="name"></param>
       /// <param name="vintage"></param>
       /// <param name="country"></param>
       /// <param name="dateAdded"></param>
       /// <param name="dateConsumed"></param>
       /// <param name="isConsumed"></param>
       /// <returns>an instance of a subclass of Wine</returns>
       /// <exception cref="NotImplementedException"></exception>
        public static Wine MakeWine(WineType type, string name, int vintage, Countries country, 
            DateTime dateAdded, DateTime dateConsumed, bool isConsumed)
        {
            switch (type)
            {
                case WineType.Rosé: 
                    return new RoseWine(name, 
                        vintage, 
                        country, 
                        dateAdded, 
                        dateConsumed, 
                        isConsumed);
                case WineType.Rött: 
                    return new RedWine(name, 
                        vintage, 
                        country, 
                        dateAdded, 
                        dateConsumed, 
                        isConsumed);
                case WineType.Vitt: 
                    return new WhiteWine(name, 
                        vintage, 
                        country, 
                        dateAdded, 
                        dateConsumed, 
                        isConsumed);
                case WineType.Sött: 
                    return new SweetWine(name, 
                        vintage, 
                        country, 
                        dateAdded, 
                        dateConsumed, 
                        isConsumed);
                default:
                    throw new NotImplementedException("Unsupported wine type");
            }
        }
    }
}
