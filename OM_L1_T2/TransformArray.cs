using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_L1_T2
{
    class TransformArray
    {
        public static int[,] numarray = { };
        public static int rows;
        public static int columns;

        public static void GetRows(int[,] numarray)
        {
            rows = numarray.GetUpperBound(0) + 1;
        }

        public static void GetColumns (int[,] numarray, int rows)
        {
            columns = numarray.Length / rows;
        }

        public static void TransformA(int[,] numarray)
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
