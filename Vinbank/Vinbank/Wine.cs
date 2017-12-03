using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vinbank
{
    public class Wine
    {
        /// <param name="wine">Copy constructor</param>
        public Wine(Wine wine)
        {
            throw new System.NotImplementedException();
        }

        public WineType WineType
        {
            get => default(int);
            set
            {
            }
        }

        public CharacterTypes CharacterType
        {
            get => default(CharacterTypes);
            set
            {
            }
        }

        public string Name
        {
            get => default(string);
            set
            {
            }
        }

        public DateTime DateAdded
        {
            get => default(DateTime);
            set
            {
            }
        }

        public bool IsConsumed
        {
            get => default(bool);
            set
            {
            }
        }

        public int Vintage
        {
            get => default(int);
            set
            {
            }
        }

        public CharacterTypes CharacterTypes
        {
            get => default(CharacterTypes);
            set
            {
            }
        }

        public WineType WineType1
        {
            get => default(WineType);
            set
            {
            }
        }

        public void Consume()
        {
            throw new System.NotImplementedException();
        }

        public void Unconsume()
        {
            throw new System.NotImplementedException();
        }
    }
}