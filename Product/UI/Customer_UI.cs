using System;

namespace Product.UI
{
    internal class Customer_UI
    {
        public static void MenuForCustomer()
        {
            Console.Clear();
            Console.WriteLine("1.View all the products");
            Console.WriteLine("2.Buy Product");
            Console.WriteLine("3.Generate Invoice");
            Console.WriteLine("4.View Profile");
            Console.WriteLine("5.Exit");
                       
        }
        public static Customer TakeInputFromUser()
        {
            Console.Clear();
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Contact: ");
            string contact = Console.ReadLine();
            return new Customer(username, password, email, address, contact);

        }
    }
}
