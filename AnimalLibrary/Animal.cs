using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    public abstract class Animal
    {
        public string Type; //(predator, herbivorous)
        public string Form;

        public abstract void Move();
        public abstract void Eat();
    }
}
