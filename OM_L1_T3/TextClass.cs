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
        private string mystring2;
        private string mystring3;
        public string stringToRemove;
        public string toRemove;

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

        //show fields on display using methods, as fields will be private
        public void ShowString1()
        {
            Console.WriteLine(mystring1);
        }

        public void ShowString2()
        {
            Console.WriteLine(mystring2);
        }

        public void ShowString3()
        {
            Console.WriteLine(mystring3);
        }

        public void RemoveString()
        {
            if (stringToRemove == "first")
            {
                Console.WriteLine("row {0} has been removed", mystring1);
                mystring1 = null;
            }
            else if (stringToRemove == "second")
            {
                Console.WriteLine("row {0} has been removed", mystring2);
                mystring2 = null;
            }
            else if (stringToRemove == "third")
            {
                Console.WriteLine("row {0} has been removed", mystring3);
                mystring3 = null;
            }
            else if (stringToRemove == "all")
            {
                Console.WriteLine("your text will be removed");
                mystring1 = null;
                mystring2 = null;
                mystring3 = null;
            }
            else
            {
                Console.WriteLine("Nothing will be removed as specified row does not match one of possible variants");
            }

        }
        public void ReplaceString()
        {

        }

    }
}
