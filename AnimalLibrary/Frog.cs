using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    class Frog:Reptile
    {
        public override void Eat()
        {
            Console.WriteLine("Frog eats insects");
        }

        public override void Move()
        {
            Console.WriteLine("Frog can creep, jump and swim");
        }
    }
}
