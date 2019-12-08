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
        private string tempReplacementVariable;
        private int length1;
        private int length2;
        private int length3;
        public string TempReplacementVariable
        {
            get { return tempReplacementVariable; }
            set { tempReplacementVariable = value; }
        }

        public string Mystring1
        {
            get { return mystring1; }
            set { mystring1 = value; }
        }

        public string Mystring2
        {
            get { return mystring2; }
            set { mystring2 = value; }
        }
        public string Mystring3
        {
            get { return mystring3; }
            set { mystring3 = value; }
        }

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
            TempReplacementVariable = Mystring2;
            Mystring2 = Mystring1;
            Mystring1 = TempReplacementVariable;
        }

        public int MyStringLength()
        {
            length1 = mystring1.Length;
            length2 = mystring2.Length;
            length3 = mystring3.Length;

            if (length1 > length2 & length1 > length3)
            {
                Console.WriteLine("Row {0} is the longest. It contains {1} symbols", mystring1, length1);
                return length1;
            }
            else if (length2 > length3)
            {
                Console.WriteLine("Row {0} is the longest. It contains {1} symbols", mystring2, length2);
                return length2;
            }
            else
            {
                Console.WriteLine("Row {0} is the longest. It contains {1} symbols", mystring3, length3);
                return length3;
            }
                
        }

    }
}
