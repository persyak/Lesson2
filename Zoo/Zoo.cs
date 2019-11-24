using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Zoo
    {
        internal string[] Aviary;
        public bool IsOpened { get; set; }
        internal Zoo(string[] aviary, bool isOpened)
        {
            Aviary = aviary; 
            IsOpened = isOpened;
        }

    }
}
