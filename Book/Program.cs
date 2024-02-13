using System;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declare an array of 100 
            book[] books = new book[100];

            // Testing 
            book book1 = new book("Comics", new string[] { "Ali", "Butt" }, "ME", "ISBN1e", 20.99, 50);
            book book2 = new book("T2", new string[] { "Me","Butt","Mobeen" }, "aLi", "ISBN2", 15.50, 100);

            Console.WriteLine("Book 1 Title: {0}" , book1.Title());
            Console.ReadLine();

            Console.WriteLine("Book 1 Authors: " + string.Join(", ", book1.GetAuthors()));
            Console.ReadLine();
            Console.WriteLine("Book 1 Publisher: " + book1.GetPublisher());
            Console.ReadLine();
            Console.WriteLine("Book 1 ISBN: " + book1.GetISBN());
            Console.ReadLine();
            Console.WriteLine("Book 1 Price: " + book1.GetPrice());
            Console.ReadLine();
            Console.WriteLine("Book 1 Stock: " + book1.GetStock());
            book1.UpdateStock(-10); // Reduce stock by 10
            Console.WriteLine("Book 1 Stock after update: " + book1.GetStock());
            Console.ReadLine();

            Console.ReadLine(); 
            Console.WriteLine("Book 2 Authors: " + string.Join(", ", book2.GetAuthors()));
            Console.ReadLine();
            Console.WriteLine("Book 2 Publisher: " + book2.GetPublisher());
            Console.ReadLine();
            Console.WriteLine("Book 2 ISBN: " + book2.GetISBN());
            Console.ReadLine();
            Console.WriteLine("Book 2 Price: " + book2.GetPrice());
            Console.ReadLine();
            Console.WriteLine("Book 2 Stock: " + book2.GetStock());
            Console.ReadLine();
            
            book2.UpdateStock(20); // Increase stock by 20
            Console.WriteLine("Book 2 Stock after update: " + book2.GetStock());
            Console.ReadLine();
        }
    }
}
    //        int bookCount = 0;
    //        book[] Book = new book[100];
    //        while (true)
    //        {
    //            Console.WriteLine("1.Add Book");
    //            Console.WriteLine("2.Search Book");
    //            Console.WriteLine("3.Book by ISBN");
    //            Console.WriteLine("4.Update Copies");
    //            Console.WriteLine("5.Exit");
    //            int choice;
    //            Console.WriteLine("Enter your Choice...");
    //            choice = int.Parse(Console.ReadLine());
    //            if (choice == 1)
    //            {
    //                Console.Clear();
    //                Console.WriteLine("\t\t\tADD BOOK");
    //                Console.Write("Enter title: ");
    //                string title = Console.ReadLine();
    //                Console.Write("Enter number of authors (up to 4): ");
    //                int numAuthors = int.Parse(Console.ReadLine());
    //                string[] authors = new string[numAuthors];
    //                for (int i = 0; i < numAuthors; i++)
    //                {
    //                    Console.Write($"Enter author {i + 1}: ");
    //                    authors[i] = Console.ReadLine();
    //                }
    //                Console.Write("Enter publisher: ");
    //                string publisher = Console.ReadLine();
    //                Console.Write("Enter ISBN: ");
    //                string ISBN = Console.ReadLine();
    //                Console.Write("Enter price: ");
    //                double price = double.Parse(Console.ReadLine());
    //                Console.Write("Enter stock: ");
    //                int stock = int.Parse(Console.ReadLine());

//                Book[bookCount] = new book(title, authors, publisher, ISBN, price, stock);
//                bookCount++;
//                Console.ReadLine();
//            }
//            else if (choice == 2)
//            {
//                Console.Write("Enter title to search: ");
//                string searchTitle = Console.ReadLine();
//                for (int i = 0; i < bookCount; i++)
//                {
//                    if (Book[i].SimilarTitle(searchTitle))
//                    {
//                        Book[i].Title();

//                    }
//                }
//                Console.ReadLine();
//            }

//            else if (choice == 3)
//            {
//                Console.WriteLine("Enter ISBN: ");
//                string searchISBN=Console.ReadLine();
//                if(searchISBN==)
//            }
//            // Add cases for other operations (search by ISBN, update stock)
//            else if (choice == 5)
//            {
//                Console.WriteLine("Exiting...");
//            }
//            else
//            {
//                Console.WriteLine("Invalid choice.");
//            }
//            }
//        }
//    }
//}

