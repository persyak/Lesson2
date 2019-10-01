using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    class GoldFish:Fish
    {
        public string Wishes;

        public new void Eat()
        {
            Console.WriteLine("GoldFish eats {0}", Wishes);
        }

        public new void Move()
        {
            Console.WriteLine("Goldfish can swim and fly");
        }
    }
}
