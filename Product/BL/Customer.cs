using System.Collections.Generic;

namespace Product
{
    internal class Customer
    {
        public string username;
        public string password;
        public string email;
        public string address;
        public string contact;
        public List<Product> products = new List<Product>();

        public Customer()
        {

        }
        public Customer(string username, string password, string email, string address, string contact)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.address = address;
            this.contact = contact;
            
        }

        public string DisplayCustomer()
        {
            return $"{username},{password},{email},{address},{contact}";

        }
    }
}
