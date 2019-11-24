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
            //створюємо масив
            int[,] numarray = { { 1, 2, 3, 4}, {5, 6, 7, 8 }, {9, 10, 11, 12 }, {13, 14, 15, 16} };
            
            //визначаємо кількість ліній
            int rows = numarray.GetUpperBound(0) + 1;
            
            //визначаємо кількість стовпців
            int columns = numarray.Length/rows;
            
            //виведемо всі елементи масиву на екран
            for (int i=0; i<rows; i++)
            {
                for (int j=0; j<columns; j++)
                {
                    Console.Write($"{numarray[i,j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // цикл для визначення всіх елементів массиву до діагоналі і присвоєння їм нуля;
            for(int i=0; i<rows; i++)
            {
                for(int j=0;j<i;j++)
                {
                    numarray[i, j] = 0;
                    //Console.Write($"{numarray[i, j]} \t");
                }
            }
            
            // цикл для визначення всіх елементів массиву після діагоналі і присвоєння їм 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = columns-1; j > i; j--)
                {
                    numarray[i, j] = 1;
                    //Console.Write($"{numarray[i, j]} \t");
                }
            }

            // виведемо всі елементи массиву на екран зі змінами
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numarray[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
