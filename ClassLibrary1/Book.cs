using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Book
    {
        public Book()
        {
            _no++;
            No = _no;
        }
        static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public string AuthorName { get; set; }
       
    }
}
