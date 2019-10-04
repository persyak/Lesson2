using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStorage
{
    class Program
    {

        static void Main(string[] args)
        {
            var storage = new BookStorage();
            var bookmanager = new BookManager("EvBaz");

            storage.AddBook("Kolobok", "OMaievskiy");
            storage.AddBook("SonFather", "SKolenko");
            storage.AddBook("123", "OOgorodnik");

            void BookProcess(Book book)
            {
                

            }

        }
    }
}
