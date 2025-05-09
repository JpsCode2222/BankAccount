using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class SavingBankAccount: BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingBankAccount(string owner, decimal interestRate):base(owner)
        {
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You cannot deposit " + amount;
            if (amount > 20000)
                return "AML Account Limit Reach";
            decimal InterestRateAmount = (amount / 100) * InterestRate;
            Balance += amount+InterestRateAmount;
            return "Successfully deposite " + amount;
        }
    }
}
