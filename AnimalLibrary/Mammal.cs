using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    public abstract class Mammal:Animal
    {
        public string TailSize;

        public abstract void UseVoice();
    }
}
