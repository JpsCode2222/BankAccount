namespace BankAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // create a sample bankaccount 
            BankAccount account1 = new BankAccount("John Doe");

            BankAccount account2 = new BankAccount("Jayad Pathan");

            BankAccount account3 = new BankAccount("Tonny Stark");

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(account1);
            bankAccounts.Add(account2);
            bankAccounts.Add(account3);

            dataGridView1.DataSource = bankAccounts;
        }
    }
}
