using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Start_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] myString;
            myString = new string[5,5];
            string k = "*";

            for (int i=0; i<5; i++)
            {
                for (int j=0; j<=i; j++)
                {
                    myString[i, j] = k;
                    Console.Write("{0}\t", myString[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
