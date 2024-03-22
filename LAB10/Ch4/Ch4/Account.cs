using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    internal class Account
    {
        protected string name;
        protected double amount;
        protected string type;
        public Account() { }
        public Account(string name, double amount, string type)
        {
            this.name = name;
            this.amount = amount;
            this.type = type;
        }
        public string toString()
        {
            return $"Name: {name} Amount: {amount} Type: {type} ";

        }

    }
}
