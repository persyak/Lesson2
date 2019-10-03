using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_lesson4
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> country = new Dictionary<string, int>(5);
            country.Add("Germany", 80);
            country.Add("Brazil", 150);
            country.Add("Spain", 60);
            country.Add("Indonesia", 80);
            country.Add("Slovenia", 80);


            //использовать структуры (List) и LINQ запросы.
        }

    }
}
