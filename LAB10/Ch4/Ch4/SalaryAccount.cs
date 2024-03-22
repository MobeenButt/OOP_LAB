using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    internal class SalaryAccount:Account
    {
        private double salary;
        private double taxAmount;

       public SalaryAccount(double salary, double taxAmount,string name,string type,double amount):base(name,amount,type)
        {
            this.type = type;   
            this.name = name;   
            this.amount = amount;
            this.salary = salary;
            this.taxAmount = taxAmount;
        }
        public string getName()
        {
            return name;
        }
        public double getSalary() {
            return salary;

        }
        public string getType()
        {
            return type;
        }
        public void setSalary(double salary) {this.salary = salary;
        }
        public double tax(double amount) {
            return taxAmount = taxAmount - amount;
        }
      
    }
}
