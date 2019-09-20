using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{

    class Program
    {
        enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string personName = Console.ReadLine();

            Console.WriteLine("Your gender?");
            string personGender = Console.ReadLine();

            Console.WriteLine("What's your height? (Please specify in cm)");
            string personHeight = Console.ReadLine();

            Console.WriteLine("What's the day of week? (Monday-Sunday)");
            string dayOfWeek = Console.ReadLine();
            Day dayOfWeekEnum;
            Enum.TryParse(dayOfWeek, out dayOfWeekEnum);

            int personHeightcm = 0;
            Int32.TryParse(personHeight, out personHeightcm);

            bool IsBatmanOpened(Day day)
            {
                if (day == Day.Monday || day == Day.Wednesday || day == Day.Friday)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
                bool IsBatman(int h)
                {
                    if (h > 150)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                bool isBatman = IsBatman(personHeightcm);
                bool isBatmanOpened = IsBatmanOpened(dayOfWeekEnum);

                if (personGender == "Male" && isBatman && isBatmanOpened)
                {
                    Console.WriteLine("child {0} is able to attend Batman", personName);
                    Console.ReadLine();
                }
            }
        }
}
//if (dayOfWeekEnum == Day.Monday || dayOfWeekEnum == Day.Wednesday || dayOfWeekEnum == Day.Friday)