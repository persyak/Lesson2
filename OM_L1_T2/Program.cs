using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_L1_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TransformArray.numarray = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            TransformArray.GetRows(TransformArray.numarray);
            TransformArray.GetColumns(TransformArray.numarray, TransformArray.rows);

            //Show all array elements on display
            for (int i=0; i< TransformArray.rows; i++)
            {
                for (int j=0; j< TransformArray.columns; j++)
                {
                    Console.Write($"{TransformArray.numarray[i,j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            TransformArray.TransformA(TransformArray.numarray);

                // display all array elemenst with changes
                Console.WriteLine("Array has been transformed");
                for (int i = 0; i < TransformArray.rows; i++)
                {
                for (int j = 0; j < TransformArray.columns; j++)
                {
                    Console.Write($"{TransformArray.numarray[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
