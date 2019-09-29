using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    class Shark:Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Shark eats {0}", Food);
        }

        public override void Move()
        {
            Console.WriteLine("Shark swims extremely fast");
        }
    }
}
