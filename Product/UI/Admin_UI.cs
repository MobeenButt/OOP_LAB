using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.UI
{
    internal class Admin_UI
    {
        public static string Menu()
        {
            Console.Clear();



            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Product with Highest Unit Price");
            Console.WriteLine("4. View Sales Tax of All Products");
            Console.WriteLine("5. Products to be Ordered");
            Console.WriteLine("6. View Profile");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        public static Admin TakeInput()
        {
            Console.Clear();
            Console.Write("Enter UserName: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            return new Admin(username, password);
        }
    }
}
