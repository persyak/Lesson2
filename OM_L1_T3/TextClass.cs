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
        public string mystring2;
        public string mystring3;
        
        public TextClass()
        {
        }
        public void AddString1FromConsole()
        {
            mystring1 = Console.ReadLine();
        }
        public void AddString2FromConsole()
        {
            mystring2 = Console.ReadLine();
        }
        public void AddString3FromConsole()
        {
            mystring3 = Console.ReadLine();
        }
    }
}
