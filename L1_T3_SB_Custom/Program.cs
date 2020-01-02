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
                //Structure to allow user to choose only action from the list
                if (myStringClass.InputChoice == "add new string" | myStringClass.InputChoice == "remove string" |
                        myStringClass.InputChoice == "replace string" | myStringClass.InputChoice == "clear all text" |
                        myStringClass.InputChoice == "get longest string" | myStringClass.InputChoice == "stop this hell")
                {

                    int position = myStringClass.InputChoice.IndexOf(" ");
                    choiceidentifier = myStringClass.InputChoice.Substring(0, position);

                    switch (choiceidentifier)
                    {
                        case "add":
                            Console.WriteLine("Please insert a string");
                            myStringClass.InstertStringCycleMethod();
                            Console.WriteLine("You have next strings:{0}", myStringClass.MyString);
                            break;

                        case "remove":
                            try
                            {
                                //Call method to split string into substrings and show each as separate string
                                myStringClass.SeparateStringToSubstrings();
                                Console.WriteLine("Now you have {0} strings in your text", myStringClass.strlist.Length);
                                if (myStringClass.strlist.Length == 1)
                                {
                                    myStringClass.ClearMyString();
                                }
                                else
                                {
                                    foreach (String s in myStringClass.strlist)
                                    {
                                        Console.WriteLine(s);
                                    }
                                    Console.WriteLine("What string would you like to remove? (please insert number of the string)");
                                    myStringClass.RemoveString();
                                    Console.WriteLine(myStringClass.MyString);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("-------------------\nALERT!\nYou do not have either 1 row. Insert at least 1 string at first");
                            }
                            break;

                        case "replace":
                            try
                            {
                                //Call method to split string into substrings and show each as separate string
                                myStringClass.SeparateStringToSubstrings();
                                if (myStringClass.strlist.Length == 1)
                                {
                                    string strtoreplace = myStringClass.MyString;
                                    Console.WriteLine("---------------\nYou have only one string.\nInsert a replacement element");
                                    string newstr = Console.ReadLine();
                                    myStringClass.ReplaceStringMethod(strtoreplace, newstr);

                                }
                                else
                                {
                                    Console.WriteLine("What element would you like to replace?");
                                    string strtoreplace = Console.ReadLine();

                                    Console.WriteLine("Insert a replacement element");
                                    string newstr = Console.ReadLine();

                                    myStringClass.ReplaceStringMethod(strtoreplace, newstr);
                                }
                                Console.WriteLine("Your replaced string is\n{0}\n---------------", myStringClass.MyString);
                            }
                            catch
                            {
                                Console.WriteLine("-------------------\nALERT!\nYou do not have either 1 row. Insert at least 1 string at first");
                            }
                            break;

                        case "clear":
                            try
                            {
                                //Call method to split string into substrings and show each as separate string
                                myStringClass.SeparateStringToSubstrings();
                                //Call method to clear all text
                                myStringClass.ClearMyString();
                            }
                            catch
                            {
                                Console.WriteLine("-------------------\nYour string is empty. You have nothing to clear\nInsert any string at first");
                            }
                            break;

                        case "get":
                           try
                            {
                                //Call method to split string to array of substrings
                                myStringClass.SeparateStringToSubstrings();
                                if (myStringClass.strlist.Length == 1)
                                {
                                    Console.WriteLine("You have only one string. It's length is {0}", myStringClass.MyString.Length);
                                }
                                else
                                {
                                    Console.WriteLine("Now you have {0} strings in your text", myStringClass.strlist.Length);
                                    int maxelement = 0;
                                    string longeststrings = null;
                                    int count = 1;
                                    foreach (String s in myStringClass.strlist)
                                    {
                                        //Console.WriteLine(s);
                                        int y = s.Length;
                                        if (y > maxelement)
                                        {
                                            maxelement = y;
                                            longeststrings = s;
                                        }
                                        else if (y == maxelement)
                                        {
                                            longeststrings = String.Concat(longeststrings, ", ", s);
                                            count = ++count;
                                        }
                                    }
                                    Console.WriteLine("You have {0} longest string(s).They are \"{1}\". The length of each of them is {2} symbols", count, longeststrings, maxelement);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("-------------------\nYour string is empty. You have nothing to calculate\nInsert any string at first");
                            }
                            
                            break;

                        case "stop":
                            Console.WriteLine("Application will be finished");
                            Console.ReadLine();
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
        }
    }
}
