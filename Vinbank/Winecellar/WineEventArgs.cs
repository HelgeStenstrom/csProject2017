//WineEventsArgs.cs
//Helge Stenström ah7875
//2018

using System;

namespace Winecellar 
{
    public class WineEventArgs : EventArgs
    {
        public string Interesting { get; set; }
        public DateTime When { get; set; }
    }
}
