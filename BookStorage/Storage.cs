using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStorage
{
    public class BookStorage
    {
        public delegate void BookProcessing(Book book);
        public delegate void UpdateDelegate(string bookTitle);

        private List<Book> _collection = new List<Book>();


        public void AddBook(string name, string author, UpdateDelegate updateManager)
        {
            _collection.Add(new Book(name, author));
            updateManager(name);
        }

    }
}
