using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_L1_T3
{
    class TextClass
    {
        //variables are private by default
        private string mystring1;
        public string _mystring2;
        public string _mystring3;
        
        public TextClass(string mystring3)
        {
        }
        public void AddStringFromConsole()
        {
            //Console.WriteLine("Please type any expression");
            mystring1 = Console.ReadLine();
       }
        public void AddStringToTheTextClass1(string mystring2)
        {
            //Console.WriteLine("Please type any expression");
            _mystring2 = mystring2;
        }
    }
}
