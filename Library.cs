using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    internal class Library:Book
    {
        List<Book> books = new List<Book>();
       
        public Book[] _books;
      

        public List<Book> FindAllBooksByName(string value)
        {
           List<Book> books=new List<Book>();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Name.Contains(value) || books[i].AuthorName.Contains(value))

                {
                    books.Add(books[i]);
                }
            }
            return books;
           

        }
        public List<Book> RemoveAllBookByName(string value)
        {
           for (int i=0;i< books.Count; i++)
            {
                if (books[i].Name.Contains(value) || books[i].AuthorName.Contains(value))
                {
                    books.Remove(books[i]);
                }
            }
            return books;

        }
        public List<Book> SearchBook(string str)
        {
            List<Book> books = new List<Book>();
            for(int i = 0; i < books.Count; i++)
            {
                string FullName = books[i].Name + " " + books[i].AuthorName + " " + books[i].PageCount + " " + books[i].No;
                if (FullName.Contains(str))
                {
                    books.Add(books[i]);
                }
            }
            return books;

        }
    }
}
