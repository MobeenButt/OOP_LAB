using Product.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DL
{
    internal class Customer_DL
    {
        public static List<Customer> customers = new List<Customer>();
        public static Customer customer = new Customer();
        public static void AddCustomer(Customer c)
        {
            customers.Add(c);
        }

        public static void BuyProduct()
        {
            string productName = Product_UI.TakeInputforProduct();
            int productIndex = ProductManager.ProductIndex(productName);

            if (productIndex != -1)
            {
                Product product = ProductManager.products[productIndex];

                if (product.stock > 0)
                {
                    product.stock--;
                    customer.products.Add(product);
                    Console.WriteLine("Product added to cart");
                }
                else
                {
                    Console.WriteLine("Product is out of stock");
                }
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }
        public static string Profile(string username)
        {
           
            foreach(Customer customer in customers) 
            {
                if (customer.username == username)
                {
                    return customer.DisplayCustomer();
                }
            }

            return "Customer not found";
        }
        public static string GenerateInvoice()
        {
            string invoice = "";
            int totalPrice = 0;

            foreach (Product product in customer.products)
            {
                int priceBeforeTax = product.price;
                int priceAfterTax = product.CalTax();
                totalPrice += priceAfterTax;
                invoice += $"{product.name}, {priceBeforeTax}, {priceAfterTax}\n";
            }
            invoice += $"Total Price to Pay: ${totalPrice}";

            return invoice;
        }
        public static bool IsValidCustomer(string username, string password)
        {
            return customers.Any(c => c.username == username && c.password == password);
        }

    }
}

