namespace BankAccount
{
    public partial class Form1 : Form
    {
        // List of BankAccounts
        List<BankAccount> bankAccounts = new List<BankAccount>();

        public Form1()
        {
            InitializeComponent();
        }

        // on btn click add dynamic account to list and datagrid
        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ownerTxt.Text))
                return;

            if (interestRate.Value > 0)
            {
                SavingBankAccount savingBankAccount = new SavingBankAccount(ownerTxt.Text,interestRate.Value);
                bankAccounts.Add(savingBankAccount);
                interestRate.Value = 0;
            }
            else
            {
                BankAccount account = new BankAccount(ownerTxt.Text);
                bankAccounts.Add(account);
            }

            refreshGrid();
            ownerTxt.Clear();
            ownerTxt.Focus();
        }

        // function to refresh grid
        private void refreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bankAccounts;
        }

        public  void depositBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && amountNum.Value > 0)
            {
                BankAccount selectedBankAccount = dataGridView1.SelectedRows[0].DataBoundItem as BankAccount;
                MessageBox.Show(selectedBankAccount.Deposit(amountNum.Value));
                refreshGrid();
            }
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && amountNum.Value > 0)
            {
                BankAccount selectedBankAccount = dataGridView1.SelectedRows[0].DataBoundItem as BankAccount;
                MessageBox.Show(selectedBankAccount.Withdraw(amountNum.Value));
                refreshGrid();
            }
        }

    }
}
