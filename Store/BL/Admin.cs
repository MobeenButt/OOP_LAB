using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Admin
    {
        string username;
        string password;
        public Admin()
        {
           
        }
        public Admin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string ViewAdmin()
        {
            return username + " " + password;
        }

    }
}
