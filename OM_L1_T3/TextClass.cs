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
        public string mystring1;
        public string _mystring2;
        private string _mystring3;
        public TextClass(string mystring3)
        {
            //_mystring1 = mystring1;
            //_mystring2 = mystring2;
            //_mystring3 = mystring3;
        }
        public void AddStringToTheTextClass()
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
