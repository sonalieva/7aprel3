using System;
using ClassLibrary1;

namespace _7aprel3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Name = "3391km";
            book.AuthorName = "Beyza";
            book.PageCount = 1;
            Book book1 = new Book();
            book1.Name = "Opposite";
            book1.AuthorName = "Sona";
            book1.PageCount = 2;
            Book book2 = new Book();
            book2.Name = "Darkness";
            book2.AuthorName = "Sugra";
            book2.PageCount = 3;

            Library library = new Library();
            library.Books.Add(book);
            library.Books.Add(book1);
            library.Books.Add(book2);
           
            foreach (var item in library.Books)
            {
                Console.WriteLine($"book no: {item.No}  book name: {item.Name}");
            }
            foreach (var item in library.FindAllBooksByName("a"))
            {
                Console.WriteLine(item.Name);
            }
            foreach (var item in library.RemoveAllBookByName("smt"))
            {
                Console.WriteLine(item.Name);
            }
            foreach (var item in library.SearchBooks("2"))
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
