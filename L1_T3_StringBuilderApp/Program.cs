using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_T3_StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder MyStringBuilderApp = new StringBuilder();
            Console.WriteLine("You have no text", MyStringBuilderApp.ToString());
            Console.WriteLine("Please insert your string");
            MyStringBuilderApp.AppendFormat("{0}", Console.ReadLine());
            Console.WriteLine(MyStringBuilderApp.ToString());
            Console.WriteLine("Would you like to insert another text?");
            var s = Console.ReadLine();
            s = s.ToUpper();

            void InsertString ()
            {
                while (s == "YES")
                {
                    Console.WriteLine("Insert a string");
                    MyStringBuilderApp.AppendFormat("{0}", Console.ReadLine());
                    Console.WriteLine("Would you like to insert another text?");
                }
            }

            

            Console.ReadLine();
        }
    }
}
