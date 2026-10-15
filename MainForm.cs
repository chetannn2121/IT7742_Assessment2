using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankingApp
{
    public partial class MainForm : Form
    {
        private CustomerController controller = new CustomerController();

        public MainForm()
        {
            InitializeComponent();

            cboAccountType.SelectedIndex = 1;
            controller.AddCustomer("C003", "Customer", "customer@gmail.com", false);
            controller.Deposit("C003", "Investment Account", 2500m);
            txtCustomerNumber.Text = "C003";
            LoadCustomer();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCustomer();
                lblStatus.Text = "Customer found.";
            }
            catch (BankingException ex)
            {
                ShowError(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                controller.AddCustomer(txtCustomerNumber.Text, txtName.Text,
                    txtContact.Text, chkBankStaff.Checked);

                RefreshAccount();
                RefreshHistory();
                lblStatus.Text = "Customer added.";
            }
            catch (BankingException ex)
            {
                ShowError(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                controller.UpdateCustomer(txtCustomerNumber.Text, txtName.Text,
                    txtContact.Text, chkBankStaff.Checked);

                lblStatus.Text = "Customer updated.";
            }
            catch (BankingException ex)
            {
                ShowError(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Delete this customer?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                controller.DeleteCustomer(txtCustomerNumber.Text);
                txtCustomerNumber.Clear();
                txtName.Clear();
                txtContact.Clear();
                txtAmount.Clear();
                chkBankStaff.Checked = false;
                lblAccountNumber.Text = "Account number: -";
                lblBalance.Text = "Balance: $0.00";
                listHistory.Items.Clear();
                lblStatus.Text = "Customer deleted.";
            }
            catch (BankingException ex)
            {
                ShowError(ex);
            }
        }

        private void cboAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAccount();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            RunTransaction("Deposit");
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            RunTransaction("Withdraw");
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            RunTransaction("Interest");
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            RunTransaction("Fee");
        }

        private void RunTransaction(string action)
        {
            try
            {
                string number = txtCustomerNumber.Text;
                string type = cboAccountType.Text;

                if (action == "Deposit" || action == "Withdraw")
                {
                    decimal amount;

                    if (!decimal.TryParse(txtAmount.Text, out amount))
                    {
                        throw new BankingException("Enter a valid amount.");
                    }

                    if (action == "Deposit")
                    {
                        controller.Deposit(number, type, amount);
                    }
                    else
                    {
                        controller.Withdraw(number, type, amount);
                    }

                    lblStatus.Text = action + " completed.";
                }
                else if (action == "Interest")
                {
                    decimal interest = controller.AddInterest(number, type);
                    lblStatus.Text = interest > 0m ? "Interest added." : "No interest for this account.";
                }
                else
                {
                    decimal fee = controller.ApplyFee(number, type);
                    lblStatus.Text = fee > 0m ? "Fee applied." : "No fee for this account.";
                }

                RefreshAccount();
                RefreshHistory();
                txtAmount.Clear();
            }
            catch (BankingException ex)
            {
                ShowError(ex);
            }
        }

        private void LoadCustomer()
        {
            Customer customer = controller.GetCustomer(txtCustomerNumber.Text);

            if (customer == null)
            {
                throw new BankingException("Customer not found. Please check the customer number.");
            }

            txtCustomerNumber.Text = customer.CustomerNumber;
            txtName.Text = customer.Name;
            txtContact.Text = customer.Contact;
            chkBankStaff.Checked = customer.IsBankStaff;
            RefreshAccount();
            RefreshHistory();
        }

        private void RefreshAccount()
        {
            Customer customer = controller.GetCustomer(txtCustomerNumber.Text);

            if (customer == null || cboAccountType.SelectedIndex == -1)
            {
                lblAccountNumber.Text = "Account number: -";
                lblBalance.Text = "Balance: $0.00";
                return;
            }

            string number = txtCustomerNumber.Text;
            string type = cboAccountType.Text;
            lblAccountNumber.Text = "Account number: " + controller.GetAccountNumber(number, type);
            lblBalance.Text = "Balance: $" + controller.GetAccountBalance(number, type).ToString("N2");
        }

        private void RefreshHistory()
        {
            listHistory.Items.Clear();

            if (controller.GetCustomer(txtCustomerNumber.Text) == null)
            {
                return;
            }

            foreach (string entry in controller.GetHistory(txtCustomerNumber.Text))
            {
                listHistory.Items.Add(entry);
            }

            if (listHistory.Items.Count > 0)
            {
                listHistory.TopIndex = listHistory.Items.Count - 1;
            }
        }

        private void ShowError(BankingException ex)
        {
            lblStatus.Text = ex.Message;
            MessageBox.Show(ex.Message, "Banking App", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
