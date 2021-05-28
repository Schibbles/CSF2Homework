using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //fields
        //props
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        //ctors
        public Book()
        {

        }
        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }
        //methods
        public override string ToString()
        {
            return string.Format("Title: {0}\n" +
                "Author: {1}\n" +
                "Number of Pages: {2}",
                Title, Author, NumberOfPages);
        }
    }
}
