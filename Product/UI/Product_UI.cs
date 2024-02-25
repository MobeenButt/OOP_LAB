using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.UI
{
    internal class Product_UI
    {
        public static Product AddProduct()
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product Category: ");
            string category = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Stock: ");
            int stock = int.Parse(Console.ReadLine());
            Console.Write("Enter Product MinStock: ");
            int minstock = int.Parse(Console.ReadLine());

            return new Product(name, category, price, stock, minstock);
        }

        public static string TakeInputforProduct()
        {
            Console.Write("Enter Product Name: ");
            return Console.ReadLine();
        }
    }
}
