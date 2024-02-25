using System;
using System.Collections.Generic;

namespace Product
{
    public class ProductManager
    {
        public static List<Product> products = new List<Product>();



        public static void AddProduct(Product product)
        {
            products.Add(product);
        }

        public static void DisplayProducts()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }

        public static void DisplayTax()
        {
            double totalTax = 0.0;

            foreach (Product product in products)
            {
                totalTax += product.CalTax();
            }

            Console.WriteLine($"Total tax: {totalTax}");
        }
        public static Product FindProductWithHighestPrice()
        {
            if (products.Count == 0)
            {
                return null;
            }

            Product highestPriceProduct = products[0]; // Initialize with the first product

            foreach (Product product in products)
            {
                if (product.price > highestPriceProduct.price)
                {
                    highestPriceProduct = product;
                }
            }

            return highestPriceProduct;
        }
        public static string OrderedProducts()
        {
            string order = "";
            foreach (Product p in products)
            {
                if (p.RecordNeed())
                {
                    order = order + p.DisplayProduct() + "\n";
                }
            }
            return order;   
        }
        public static int ProductIndex(string name)
        {
            int index = 0;
            foreach (Product product in products)
            {
                if (product.name == name)
                {
                    return index;
                }
                index = index + 1;
            }
            return -1;
        }
    }
}
