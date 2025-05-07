namespace BankAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // create a sample bankaccount 
            BankAccount account1 = new BankAccount("John Doe");
            //account1.Owner = "Jayad Pathan";
            //account1.Account_number = Guid.NewGuid();
            //account1.Balance = 1000;

            BankAccount account2 = new BankAccount("Jayad Pathan");
            //account2.Owner = "John Doe";
            //account2.Account_number = Guid.NewGuid();
            //account2.Balance = 10000;

            BankAccount account3 = new BankAccount("Tonny Stark");
            //account3.Owner = "Tonny Stark";
            //account3.Account_number = Guid.NewGuid();
            //account3.Balance = 100000;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(account1);
            bankAccounts.Add(account2);
            bankAccounts.Add(account3);

            dataGridView1.DataSource = bankAccounts;
        }
    }
}
