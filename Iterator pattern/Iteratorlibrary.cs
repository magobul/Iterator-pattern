using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_pattern
{
    public class Iteratorlibrary : IEnumerator<Book>
    {
        private Book[] _books;
        private int _position = -1;

        public Iteratorlibrary(Book[] books)
        {
            _books = books;
        }

        public Book Current => _books[_position];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            return (_position < _books.Length);
        }

        public void Reset()
        {
            _position = -1;
        }
        public void Dispose() { }
    }
}
