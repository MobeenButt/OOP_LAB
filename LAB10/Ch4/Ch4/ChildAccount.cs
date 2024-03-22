using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    internal class ChildAccount : Account
    {
        private double DepAmount;
        public ChildAccount(double depAmount, string name, double amount, string type) :base(name, amount, type)
        {
            DepAmount = depAmount;
            this.name = name;
            this.amount = amount;
            this.type = type;   
            
        }
        public bool DepositAmount(double depAmount)
        {
            if (depAmount < 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string NString()
        {
            return $"Name: {name} Amount: {amount} Type: {type} ";

        }
        public string getType()
        {
            return type;
        }
    }
}
