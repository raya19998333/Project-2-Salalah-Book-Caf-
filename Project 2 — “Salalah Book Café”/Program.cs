using Project_2____Salalah_Book_Café_.Moduls;

namespace Project_2____Salalah_Book_Café_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create drinks
            MenuItem coffee = new MenuItem("Espresso", DrinkType.Coffee, 2.5m);
            MenuItem tea = new MenuItem("Green Tea", DrinkType.Tea, 1.8m);

            // Create books
            Book book1 = new Book("The Alchemist", "Paulo Coelho");
            Book book2 = new Book("1984", "George Orwell");
            Book book3 = new Book("Atomic Habits", "James Clear");

            // Create customers
            Customer customer1 = new Customer("Ali");
            Customer customer2 = new Customer("Fatima");

            // Orders and borrowing
            customer1.OrderDrink(coffee);
            customer1.BorrowBook(book1);
            customer1.BorrowBook(book2);
            customer1.BorrowBook(book3); // won't allow, max 2 books

            customer2.OrderDrink(tea);
            customer2.BorrowBook(book2); // won't allow, already borrowed

            // Print info
            customer1.PrintInfo();
            customer2.PrintInfo();

            // Returning books
            customer1.ReturnBooks();
            customer2.ReturnBooks();

            // Book status after return
            Console.WriteLine("Book Status After Return:");
            book1.PrintInfo();
            book2.PrintInfo();
            book3.PrintInfo();
        }
    }
}
