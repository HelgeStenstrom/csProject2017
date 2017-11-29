using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vinbank
{
    public class Wine
    {
        public WineTypes WineType
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
            get => default(int);
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
            get => default(int);
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