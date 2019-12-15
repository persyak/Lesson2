using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_T3_SB_Custom
{
    class Program
    {
        static void Main(string[] args)
        {
            StringClass myStringClass = new StringClass();
            Console.WriteLine("Hey man, insert new string");
            myStringClass.MyString = Console.ReadLine();
            Console.WriteLine(myStringClass.MyString);
            //Console.ReadLine();

            Console.WriteLine("Would you like to insert another string?");
            string x = Console.ReadLine();



            while (myStringClass.AdditionalString(x))
            {
                Console.WriteLine("Insert another string");
                myStringClass.MyString = String.Concat(myStringClass.MyString, ", ", Console.ReadLine());
                Console.WriteLine(myStringClass.MyString);
                Console.WriteLine("Another string?");
                x = Console.ReadLine();
            }
            Console.WriteLine(myStringClass.MyString);
            string[] separatingstring = {", "};
            String[] strlist = myStringClass.MyString.Split(separatingstring, StringSplitOptions.None);
            
            Console.WriteLine("Now you have {0} strings in your text", strlist.Length);
            foreach (String s in strlist)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("What string would you like to remove? (please insert number of the string)");
            string r = Console.ReadLine();
            int rint;
            Int32.TryParse(r, out rint);

            List<string> list = new List<string>(strlist);
            list.RemoveAt(rint-1);
            myStringClass.MyString = string.Join(", ", list.ToArray());
            Console.WriteLine(myStringClass.MyString);
            Console.WriteLine("What element would you like to replace?");
            string strtoreplace = Console.ReadLine();
            Console.WriteLine("Insert a replacement element");
            string newstr = Console.ReadLine();
            myStringClass.MyString = myStringClass.MyString.Replace(strtoreplace, newstr);
            Console.WriteLine("Your replaced string: {0}", myStringClass.MyString);

            Console.WriteLine("Full string length is {0} characters", myStringClass.MyString.Length);
            Console.ReadLine();
        }
    }
}
