using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        // Properties
        public string Owner { get; set; }
        public Guid Account_number { get; set; }
        public decimal Balance { get; protected set; }

        // Constructor
        public BankAccount(string owner)
        {
            Owner = owner;
            Account_number = Guid.NewGuid();
            Balance = 0;
        }

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You cannot deposit " + amount;
            if (amount > 20000)
                return "AML Account Limit Reach";

            Balance += amount;
            return "Successfully deposite " + amount;
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "You cannot withdraw " + amount;
            if (amount > 20000)
                return "AML Account Limit Reach";

            Balance -= amount;
            return "Successfully withdraw " + amount;
        }

    }
}
