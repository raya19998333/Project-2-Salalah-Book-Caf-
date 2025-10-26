using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2____Salalah_Book_Café_.Moduls
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; } = false;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void PrintInfo()
        {
            string status = IsBorrowed ? "Borrowed" : "Available";
            Console.WriteLine($"{Title} by {Author} - {status}");
        }
    }
}
