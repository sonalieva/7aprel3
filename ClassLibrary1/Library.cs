using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Library
    {
        List<Book> _books = new List<Book>();
        public List<Book> Books { get { return _books; } }


        public List<Book> FindAllBooksByName(string smth)
        {
            List<Book> Books1 = new List<Book>();
            foreach (var item in _books)
            {
                if (item.Name.Contains(smth))
                {
                    Books1.Add(item);
                }
            }
            return Books1;


             List<Book> RemoveAllBookByName(string smth)
            {
                List<Book> Books1 = new List<Book>();
                foreach (var item in _books)
                {
                    if (!item.Name.Contains(smth))
                    {
                        Books1.Add(item);
                    }
                }
                return Books1;

                 List<Book> SearchBooks(string smth)
                {
                    List<Book> Books1 = new List<Book>();
                    foreach (var item in _books)
                    {
                        if (item.Name.Contains(smth) || item.AuthorName.Contains(smth) )
                        {
                            Books1.Add(item);
                        }
                    }
                    return Books1;
                }
            }
        }
    }
}
