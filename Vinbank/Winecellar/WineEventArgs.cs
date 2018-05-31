//WineEventsArgs.cs
//Helge Stenström ah7875
//2018

using System;

namespace Winecellar 
{
    /// <summary>
    /// Data transfer object for wine events.
    /// </summary>
    public class WineEventArgs : EventArgs
    {
        public string Message { get; set; }
        public DateTime When { get; set; }
    }
}
