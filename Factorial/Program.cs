using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {        
            int y = 1;

            int CalculateFactorial (int i)
            {
                for (int z = 1; z <= i; z++)
                {
                    y = y * z;
                }
                return y;
            }
            Console.WriteLine("Please enter a number");
            int myNumber = Convert.ToInt32(Console.ReadLine());
            //Console.ReadLine();
            //Int32.TryParse(s, out myNumber);
            int f = CalculateFactorial(myNumber);
            Console.WriteLine("{0} Factorial is equal {1}", myNumber, f);
            Console.ReadLine();
        }
    }
}
