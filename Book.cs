using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    internal class Book
    {
        public string No;
        public string Name;
        public string AuthorName;
        public int PageCount;

        public static implicit operator string(Book v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Book(string v)
        {
            throw new NotImplementedException();
        }
    }
}
