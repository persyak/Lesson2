using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_L1_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextClass myText = new TextClass();

            Console.WriteLine("Insert first row");
            myText.AddString1FromConsole();

            Console.WriteLine("Insert second row");
            myText.AddString2FromConsole();

            Console.WriteLine("Insert third row");
            myText.AddString3FromConsole();

            Console.WriteLine(myText.mystring1);
            Console.WriteLine(myText.mystring2);
            Console.WriteLine(myText.mystring3);
            Console.ReadLine();
            
        }
    }
}
