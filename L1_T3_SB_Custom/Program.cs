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
                myStringClass.MyString = String.Concat(myStringClass.MyString, " ", Console.ReadLine());
                Console.WriteLine(myStringClass.MyString);
                Console.WriteLine("Another string?");
                x = Console.ReadLine();
            }
            Console.WriteLine(myStringClass.MyString);
            String[] spearator = {" "};
            myStringClass.MyString.Split(spearator);
            Console.ReadLine();
            foreach (String s in myStringClass.MyString)
            {

            }
        }
    }
}
