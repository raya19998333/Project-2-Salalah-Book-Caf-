using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2____Salalah_Book_Café_.Moduls
{
    class Customer
    {
        public string Name { get; set; }
        public List<MenuItem> OrderedDrinks { get; set; } = new List<MenuItem>();
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public Customer(string name)
        {
            Name = name;
        }

        public void OrderDrink(MenuItem drink)
        {
            OrderedDrinks.Add(drink);
            Console.WriteLine($"{Name} ordered {drink.Name}");
        }

        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count >= 2)
            {
                Console.WriteLine($"{Name} cannot borrow more than 2 books.");
                return;
            }

            if (book.IsBorrowed)
            {
                Console.WriteLine($"{book.Title} is already borrowed.");
            }
            else
            {
                BorrowedBooks.Add(book);
                book.IsBorrowed = true;
                Console.WriteLine($"{Name} borrowed {book.Title}");
            }
        }

        public void ReturnBooks()
        {
            foreach (var book in BorrowedBooks)
            {
                book.IsBorrowed = false;
                Console.WriteLine($"{Name} returned {book.Title}");
            }
            BorrowedBooks.Clear();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Customer: {Name}");
            Console.WriteLine("Ordered Drinks:");
            foreach (var drink in OrderedDrinks) drink.PrintInfo();
            Console.WriteLine("Borrowed Books:");
            foreach (var book in BorrowedBooks) book.PrintInfo();
            Console.WriteLine("-----------------------------------");
        }
    }
}
