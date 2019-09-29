using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Zoo
    {
        internal string[] _aviary;
        internal bool IsOpened
        {
            get { return true; }
            set { IsOpened = value; }
        }
        internal Zoo(string[] aviary, bool IsOpened)
        {
            _aviary = aviary;
        }
    }
}
