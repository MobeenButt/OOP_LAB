using Product.DL;
using Product.UI;
using System;

namespace Product.Utility
{
    internal class Display
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Departmental Store Management System!");

            while (true)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Sign In");
                Console.WriteLine("2. Sign Up");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SignIn();
                        break;
                    case "2":
                        SignUp();
                        break;
                    case "3":
                        Console.WriteLine("Thank you for using the system. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void SignIn()
        {
            Console.WriteLine("\nSign In:");
            Console.Write("Enter Username: ");
            string username = Console.ReadLine().Trim(); // Trim to remove leading/trailing spaces
            Console.Write("Enter Password: ");
            string password = Console.ReadLine().Trim(); // Trim to remove leading/trailing spaces

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (Admin_DL.IsValidAdmin(username, password))
                {
                    AdminMenu();
                }
                else if (Customer_DL.IsValidCustomer(username, password))
                {
                    CustomerMenu(username);
                }
               
            }
            
        }



        static void SignUp()
        {
            Console.WriteLine("\nSign Up:");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Customer");
            Console.Write("Choose user type: ");
            string userType = Console.ReadLine();

            switch (userType)
            {
                case "1":
                    Admin_UI.TakeInput();
                    break;
                case "2":
                    Customer_UI.TakeInputFromUser();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void AdminMenu()
        {
            while (true)
            {
                string choice = Admin_UI.Menu();
                switch (choice)
                {
                    case "1":
                        Product p = Product_UI.AddProduct();
                        ProductManager.AddProduct(p);
                        break;
                    case "2":
                        ProductManager.DisplayProducts();
                        break;
                    case "3":
                        ProductManager.FindProductWithHighestPrice();
                        break;
                    case "4":
                        ProductManager.DisplayTax();
                        break;
                    case "5":
                        ProductManager.OrderedProducts();
                        break;
                    case "6":
                        // Admin_UI.ViewProfile(); // Functionality not implemented
                        break;
                    case "7":
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CustomerMenu(string username)
        {
            while (true)
            {
                Customer_UI.MenuForCustomer();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ProductManager.DisplayProducts();
                        break;
                    case "2":
                        Customer_DL.BuyProduct();
                        break;
                    case "3":
                         Customer_DL.GenerateInvoice(); 
                        break;
                    case "4":
                        Customer_DL.Profile(username);
                        break;
                    case "5":
                      Environment.Exit(0);  
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
