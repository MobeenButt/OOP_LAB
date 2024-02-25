using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Admin
    {
        public string username;
        public string password;
        public Admin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string DisplayAdmin()
        {
            return $"{username},{password}";
        }
    }
}
