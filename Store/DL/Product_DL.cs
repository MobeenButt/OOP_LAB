using System;
using System.Collections.Generic;

namespace Store
{
    internal class Product_DL
    {
       public static List<Product> products = new List<Product>();
      public  static void AddProducts(Product p)
        {
            products.Add(p);
        }
        public static void ViewProducts()
        {
            foreach (Product p in products)
            {
                Console.WriteLine(p.ViewProduct());
            }
        }

        public static double ViewTax()
        {
            double tax = 0;
            foreach (Product p in products)
            {
                tax = tax + p.PriceAfterTax();
            }
            return tax;
        }
        public static int ProductByName(string name)
        {
            foreach (Product p in products)
            {
                if()
            }
        }
    }
}
