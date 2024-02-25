using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Store
{
    internal class Customer
    {
        string username;
        string password;
        string email;
        string address;
        string contact;
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
        public string ViewCustomer()
        {
            return username + " " + password + " " + email + " " + address + " " + contact;

        }
    }
}
