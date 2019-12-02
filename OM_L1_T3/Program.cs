using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_L1_T3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            TextClass myText = new TextClass();

            Console.WriteLine("Insert first row");
            myText.AddString1FromConsole();

            Console.WriteLine("Insert second row");
            myText.AddString2FromConsole();

            Console.WriteLine("Insert third row");
            myText.AddString3FromConsole();

            Console.WriteLine("Your strings:");
            myText.ShowString1();
            myText.ShowString2();
            myText.ShowString3();
            Console.ReadLine();

            Console.WriteLine("Would you like to remove a row or whole test? Please enter 'yes' or 'no'");
            myText.toRemove = Console.ReadLine();
            if (myText.toRemove == "yes")
            {
                Console.WriteLine("Please specify row to remove: first, second, third or all");
                myText.stringToRemove = Console.ReadLine();
                myText.RemoveString();

                Console.WriteLine("Your strings after removal:");
                myText.ShowString1();
                myText.ShowString2();
                myText.ShowString3();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("please enter 'yes', if you'd like to remove a row or whole text");
                Console.ReadLine();
            }
        }
    }
}
