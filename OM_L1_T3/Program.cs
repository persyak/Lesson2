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

            Console.WriteLine("Please specify row to remove: first, second or third");
            myText.stringToRemove = Console.ReadLine();
            myText.RemoveString();

            Console.WriteLine("Your strings after remove:");
            myText.ShowString1();
            myText.ShowString2();
            myText.ShowString3();
            Console.ReadLine();
        }
    }
}
