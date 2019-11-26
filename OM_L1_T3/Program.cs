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
            Console.WriteLine("Insert a test");
            myText.AddStringToTheTextClass();
            myText.AddStringToTheTextClass1("blabla");
            Console.WriteLine(myText._mystring1);
            Console.WriteLine(myText._mystring2);
            Console.ReadLine();
            
        }
    }
}
