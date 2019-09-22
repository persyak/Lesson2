using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
            Day dayOfWeekEnum;
            int personHeightcm = 0;

            Console.WriteLine("What's your name?");
            string personName = Console.ReadLine();

            // Console.WriteLine("What's the day of week? (Monday-Sunday)");
            // string dayOfWeek = Console.ReadLine();
            string dayOfWeek = ConfigurationManager.AppSettings["DayOfWeek"];
            Enum.TryParse(dayOfWeek, out dayOfWeekEnum);

            //switch(dayOfWeekEnum)
            //{
            //    case Day.Sunday:
            //        Console.WriteLine("Closed");
            //        break;
            //}
            if (dayOfWeekEnum == Day.Sunday)
            {
                Console.WriteLine("Dear {0}, Attraction is closed today", personName);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your gender?");
                string personGender = Console.ReadLine();

                Console.WriteLine("What's your height? (Please specify in cm)");
                string personHeight = Console.ReadLine();

                Int32.TryParse(personHeight, out personHeightcm);

                Kid tom = new Kid(personName, personHeightcm, 1);

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

                bool IsSwanOpened(Day day)
                {
                    if (day == Day.Tuesday || day == Day.Wednesday || day == Day.Thursday)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                bool IsPonyOpened(Day day)
                {
                    if (day != Day.Sunday)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                bool IsBatmanAllowed(string g, int h)
                {
                    if (g == "Male" && h > 150)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                bool IsSwanAllowed(string g, int h)
                {
                    if ((g == "Female" && h >= 120 && h < 140) || (g == "Male" && h < 140))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

                bool isBatmanAllowed = IsBatmanAllowed(personGender, personHeightcm);
                bool isSwanAllowed = IsSwanAllowed(personGender, personHeightcm);
                bool isBatmanOpened = IsBatmanOpened(dayOfWeekEnum);
                bool isSwanOpened = IsSwanOpened(dayOfWeekEnum);
                bool isPonyOpened = IsPonyOpened(dayOfWeekEnum);

                if (isBatmanAllowed && isBatmanOpened)
                {
                    Console.WriteLine("Child {0} is permitted to attend Batman", personName);
                    Console.ReadLine();
                }
                else if (isSwanAllowed && isSwanOpened)
                {
                    Console.WriteLine("Child {0} is permitted to attend Swan", personName);
                    Console.ReadLine();
                }
                else if (isPonyOpened)
                {
                    Console.WriteLine("Child {0} is permitted to attend Pony", personName);
                    Console.ReadLine();
                }
            }
        }
        }
}