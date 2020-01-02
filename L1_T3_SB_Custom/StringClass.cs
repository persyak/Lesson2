using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_T3_SB_Custom
{
    class StringClass
    {
        private string mystring;
        private string inputchoice;

        public string MyString
        {
            get { return mystring; }
            set { mystring = value; }
        }

        public string InputChoice
        {
            get { return inputchoice; }
            set { inputchoice = Console.ReadLine(); }
        }

        public string[] strlist;
        string[] separatingstring = { ", " };

        //method to apply user's input when asking about user's choice
        public bool AdditionalAction(string a)
        {
            if (a!= "stop")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method to add a string to a text
        public void InstertStringCycleMethod()
        {
            if (MyString == null)
            {
                MyString = Console.ReadLine();
            }
            else
            {
                MyString = String.Concat(MyString, ", ", Console.ReadLine());
            }
        }

        //Method to split string into substrings and show each as separate string
        public void SeparateStringToSubstrings()
        {
            strlist = MyString.Split(separatingstring, StringSplitOptions.None);
        }

        //Method to remove a string
        public void RemoveString()
        {
            string r = Console.ReadLine();
            int rint;
            Int32.TryParse(r, out rint);

            List<string> list = new List<string>(strlist);
            list.RemoveAt(rint - 1);
            MyString = string.Join(", ", list.ToArray());
        }
        
        //Method to replace string with another string in a text
        public string ReplaceStringMethod(string z, string w)
        {
            return MyString = MyString.Replace(z, w);
        }
        //Method to clear all text or clear a string if the text contains only one string
        public void ClearMyString()
        {
            MyString = null;
            //Console.WriteLine(MyString);
            Console.WriteLine("You've cleared all text");
        }

    }
}
