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
            
            int myNumber;
            int y;

            int CalculateFactorial (int i)
            {
                return myNumber;
                    for (int j = 1; j <= i; j++)
                    {
                        return j * j;
                    }
                
               
            }
            Console.WriteLine("Please enter a number");
            string s = Console.ReadLine();
            Int32.TryParse(s, out myNumber);
            int f = CalculateFactorial(myNumber);
            Console.WriteLine("{0} Factorial is equal {1}", myNumber, f);
            Console.ReadLine();
        }
    }
}
