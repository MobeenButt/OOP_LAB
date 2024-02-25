using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DL
{
    internal class Admin_DL
    {
        public static List<Admin> Admin=new List<Admin>();
        public static void AddAdmin(Admin admin)
        {
            Admin.Add(admin);
        }
        public static bool IsValidAdmin(string name,string password)
        {
            foreach (Admin admin in Admin)
            {
                if(admin.username == name && admin.password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
