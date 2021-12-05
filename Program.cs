using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace Store_Book3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isShopping = true;
            List <Book> Books = new List <Book>();

            while (isShopping)
            {
                Book Book_Choised = new Book();

                Console.WriteLine("Welcome to the market sir please write the book name and the price to search for you in Stock ");
                Book_Choised.Nom = Console.ReadLine();

                Console.WriteLine("Please enter the price $ ");
                Book_Choised.Price = Convert.ToDouble(Console.ReadLine());

                Books.Add(Book_Choised);

                // Remove Book Option .
                Console.WriteLine("Do you want to remove a book sir !");
                var Remove_Book = Console.ReadLine();

                if (Remove_Book == "yes")
                {
                    Console.WriteLine("What Book you want to remove sir ");
                    var Book_Removed = Console.ReadLine();

                    Book ActualBook = new Book();

                    foreach (var ToRemove in Books)
                        if (ToRemove.Nom.Contains(Book_Removed))
                            ActualBook = ToRemove;

                        else
                            Console.Write("Looks their is no book with that name sir ");

                    Books.Remove(ActualBook);
                }

                Console.WriteLine("Do you want to keep Shopping");
                var Respond_User = Console.ReadLine();

                if (Respond_User == "no")
                {
                    isShopping = false;
                    var total = 0.00;

                    foreach (var Book in Books)
                    {
                        Console.WriteLine($"your Books: \t \n {Book.Nom}");
                        total += Book.Price;
                    }

                    Console.WriteLine($"the Total price is {total}");
                }
            }
        }
    }
}
