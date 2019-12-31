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
            string choiceidentifier = null;
            while (myStringClass.AdditionalAction(choiceidentifier))
            {
                    Console.WriteLine("Please choose action you'd like to do:\n1)add new string\n2)remove string\n" +
                    "3)replace string\n4)clear all text\n5)get longest string\n6)stop this hell");

                    myStringClass.InputChoice = myStringClass.InputChoice;

                if (myStringClass.InputChoice == "add new string" | myStringClass.InputChoice == "remove string" |
                        myStringClass.InputChoice == "replace string" | myStringClass.InputChoice == "clear all text" |
                        myStringClass.InputChoice == "get longest string" | myStringClass.InputChoice == "stop this hell")
                {

                    int position = myStringClass.InputChoice.IndexOf(" ");
                    choiceidentifier = myStringClass.InputChoice.Substring(0, position);

                    //Console.WriteLine(myStringClass.InputChoice.Substring(0, position));
                    //Console.ReadLine();
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

                        case "clear":
                            //Call method to clear all text
                            myStringClass.ClearMyString();
                            break;

                        case "get":
                            //Call method to split string to array of substrings
                            myStringClass.SeparateStringToSubstrings();
                            Console.WriteLine("Now you have {0} strings in your text", myStringClass.strlist.Length);
                            int maxelement = 0;
                            string longeststring = null;
                            foreach (String s in myStringClass.strlist)
                            {
                                //Console.WriteLine(s);
                                int y = s.Length;
                                if (y > maxelement)
                                {
                                    maxelement = y;
                                    longeststring = s;
                                }
                            }
                            Console.WriteLine("The longest string is \"{0}\". It has {1} symbols", longeststring, maxelement);
                            break;

                        default:
                            Console.WriteLine("-------------------\nALERT!\nYou can choose only actions from the list");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("-------------------\nALERT!\nYou can choose only actions from the list");
                }
            }
            
            ////Add a 1st string to the text
            //myStringClass.MyString = Console.ReadLine();
            //Console.WriteLine(myStringClass.MyString);
            
            ////insert second string
            //Console.WriteLine("Would you like to insert another string?");
            //string x = Console.ReadLine();

            ////a cycle to insert as many strings, as user wants
            //while (myStringClass.AdditionalString(x))
            //{
            //    Console.WriteLine("Insert another string");
            //    myStringClass.InstertStringCycleMethod();
            //    Console.WriteLine(myStringClass.MyString);
            //    Console.WriteLine("Another string?");
            //    x = Console.ReadLine();
            //}

            ////Call method to split string into substrings and show each as separate string
            //myStringClass.SeparateStringToSubstrings();
            //Console.WriteLine("Now you have {0} strings in your text", myStringClass.strlist.Length);
            //foreach (String s in myStringClass.strlist)
            //{
            //    Console.WriteLine(s);
            //}
            
            //Console.WriteLine("What string would you like to remove? (please insert number of the string)");
            //myStringClass.RemoveString();
            //Console.WriteLine(myStringClass.MyString);

            ////Call method to replace a string
            //myStringClass.ReplaceStringMethod();
            
            //Console.WriteLine("Full string length is {0} characters", myStringClass.MyString.Length);
            //Console.ReadLine();
        }
    }
}
