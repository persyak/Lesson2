using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_L1_T2
{
    class TransformArray
    {
        public static int[,] numarray = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

        //визначаємо кількість ліній
        public static int rows = numarray.GetUpperBound(0) + 1;

        //визначаємо кількість стовпців
        public int columns = numarray.Length / rows;

        public void TransformA(int[,] a)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j < i)
                    {
                        numarray[i, j] = 0;
                    }
                    else if (j > i)
                    {
                        numarray[i, j] = 1;
                    }
                }
            }
        }
    }
}
