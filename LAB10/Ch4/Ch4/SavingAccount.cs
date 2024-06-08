using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    internal class SavingAccount:Account
    {
        private double savingAmount;
        public SavingAccount(string name, double amount, string type,double savingAmount):base(name, amount, type)
        {
            this.savingAmount = savingAmount;
            this
                .name = name;
            this.type = type;
            this.amount= amount;    
        }
        public void setSavings(int amount)
        {
            savingAmount=savingAmount+amount;
        }

    }
}
