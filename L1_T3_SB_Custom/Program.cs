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
            Console.WriteLine("Please choose action you'd like to do:\n1)add new string\n2)remove string\n" +
                "3)replace string\n4)clear all text\n5)get longest string");

            myStringClass.InputChoice = myStringClass.InputChoice;

            int position = myStringClass.InputChoice.IndexOf(" ");
            var choiceidentifier = myStringClass.InputChoice.Substring(0, position);

            Console.WriteLine(myStringClass.InputChoice.Substring(0, position));
            Console.ReadLine();
            switch (choiceidentifier)
            {
                case "add":
                    Console.WriteLine("Please insert a string");
                    myStringClass.InstertStringCycleMethod();
                    Console.WriteLine(myStringClass.MyString);
                    break;

                case "remove":
                    //Call method to split string into substrings and show each as separate string
                    myStringClass.SeparateStringToSubstrings();
                    Console.WriteLine("Now you have {0} strings in your text", myStringClass.strlist.Length);
                    foreach (String s in myStringClass.strlist)
                    {
                        Console.WriteLine(s);
                    }

                    Console.WriteLine("What string would you like to remove? (please insert number of the string)");
                    myStringClass.RemoveString();
                    Console.WriteLine(myStringClass.MyString);
                    break;
                case "replace":
                    //Call method to replace a string
                    myStringClass.ReplaceStringMethod();
                    break;

            }
            
            //Add a 1st string to the text
            myStringClass.MyString = Console.ReadLine();
            Console.WriteLine(myStringClass.MyString);
            
            //insert second string
            Console.WriteLine("Would you like to insert another string?");
            string x = Console.ReadLine();

            //a cycle to insert as many strings, as user wants
            while (myStringClass.AdditionalString(x))
            {
                Console.WriteLine("Insert another string");
                myStringClass.InstertStringCycleMethod();
                Console.WriteLine(myStringClass.MyString);
                Console.WriteLine("Another string?");
                x = Console.ReadLine();
            }

            //Call method to split string into substrings and show each as separate string
            myStringClass.SeparateStringToSubstrings();
            Console.WriteLine("Now you have {0} strings in your text", myStringClass.strlist.Length);
            foreach (String s in myStringClass.strlist)
            {
                Console.WriteLine(s);
            }
            
            Console.WriteLine("What string would you like to remove? (please insert number of the string)");
            myStringClass.RemoveString();
            Console.WriteLine(myStringClass.MyString);

            //Call method to replace a string
            myStringClass.ReplaceStringMethod();
            
            Console.WriteLine("Full string length is {0} characters", myStringClass.MyString.Length);
            Console.ReadLine();
        }
    }
}
