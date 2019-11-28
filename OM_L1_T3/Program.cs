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
            //чому не можна використовувати "bla" як string3 після створення екземпляру класу TestClass?
            TextClass myText = new TextClass("bla");

            Console.WriteLine("Insert a test");
            myText.AddStringFromConsole();

            //myText.AddStringToTheTextClass1("blabla");
            //Console.WriteLine(myText.mystring1);
            Console.WriteLine(myText._mystring2);
            Console.WriteLine(myText._mystring3);
            Console.ReadLine();
            
        }
    }
}
