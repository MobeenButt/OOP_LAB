using System;

namespace Ch4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChildAccount c = new ChildAccount(1000, "Butt", 200, "Child");
            Console.WriteLine(c.DepositAmount(100));
            Console.WriteLine(c.getType());
            Console.WriteLine(c.NString());

            SalaryAccount s = new SalaryAccount(1000, 120, "Ali", "Salary", 12000);
            Console.WriteLine(s.tax(100));

            Console.WriteLine(s.getName());

            Console.ReadLine();
        }
    }
}
