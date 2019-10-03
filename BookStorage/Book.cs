using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStorage
{
    public class Book
    {
        private string _name;
        private string _author;

        public Book(string name, string author)
        {
            _name = name;
            _author = author;
        }
    }
}
