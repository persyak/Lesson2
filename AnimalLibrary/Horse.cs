using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    class Horse:Mammal
    {
        public override void Eat()
        {
            Console.WriteLine("Horse eats grass");
        }

        public override void Move()
        {
            Console.WriteLine("Horse runs faster than Lion");
        }
    }
}
