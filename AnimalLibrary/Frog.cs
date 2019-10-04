using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    public class Frog:Reptile
    {
        private string _color;

        internal Frog(string color)
        {
            _color = color;
        }
    }
}
