using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    class Lion:Mammal
    {
        public override void Eat()
        {
            Console.WriteLine("Lion eats meat and other animals");
        }

        public override void Move()
        {
            Console.WriteLine("Lion runs fast");
        }

        public override void UseVoice()
        {
            Console.WriteLine("Lion growls");
        }
    }
}
