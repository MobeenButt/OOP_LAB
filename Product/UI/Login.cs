using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.UI
{
    internal class Login
    {
        public static string LoginPage()
        {
            Console.Clear();
            Console.WriteLine("1.SignIn");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("3.Exit");
            Console.Write("Enter Choice: ");
            return Console.ReadLine();
        }
      
        public static string Input()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            return username + password;
        }
  
      
    }

}