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
        public double Balance { get; set; }

        // Constructor
        public BankAccount(string owner)
        {
            Owner = owner;
            Account_number = Guid.NewGuid();
            Balance = 0;
        }
    }
}
