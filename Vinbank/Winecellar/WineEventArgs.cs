using System;

namespace Winecellar 
{
    public class WineEventArgs : EventArgs
    {
        public string Interesting { get; set; }
        public DateTime When { get; set; }
    }
}
