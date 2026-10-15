namespace BankingApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblMenuText;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblCustomerNumberTitle;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.TextBox txtCustomerNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.CheckBox chkBankStaff;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.Label lblAccountTypeTitle;
        private System.Windows.Forms.ComboBox cboAccountType;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox grpTransaction;
        private System.Windows.Forms.Label lblAmountTitle;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.GroupBox grpHistory;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            pictureBoxLogo = new PictureBox();
            lblBrand = new Label();
            lblMenuText = new Label();
            grpCustomer = new GroupBox();
            lblCustomerNumberTitle = new Label();
            lblNameTitle = new Label();
            lblContactTitle = new Label();
            txtCustomerNumber = new TextBox();
            txtName = new TextBox();
            txtContact = new TextBox();
            chkBankStaff = new CheckBox();
            btnAdd = new Button();
            btnFind = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            grpAccount = new GroupBox();
            lblAccountTypeTitle = new Label();
            cboAccountType = new ComboBox();
            lblAccountNumber = new Label();
            lblBalance = new Label();
            grpTransaction = new GroupBox();
            lblAmountTitle = new Label();
            txtAmount = new TextBox();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnInterest = new Button();
            btnFee = new Button();
            grpHistory = new GroupBox();
            listHistory = new ListBox();
            lblStatusTitle = new Label();
            lblStatus = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            grpCustomer.SuspendLayout();
            grpAccount.SuspendLayout();
            grpTransaction.SuspendLayout();
            grpHistory.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 124, 124);
            panelMenu.Controls.Add(pictureBoxLogo);
            panelMenu.Controls.Add(lblBrand);
            panelMenu.Controls.Add(lblMenuText);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(150, 750);
            panelMenu.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Teal;
            pictureBoxLogo.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(29, 45);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(96, 99);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(5, 163);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(140, 35);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "BANKING APP";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMenuText
            // 
            lblMenuText.ForeColor = Color.White;
            lblMenuText.Location = new Point(5, 205);
            lblMenuText.Name = "lblMenuText";
            lblMenuText.Size = new Size(140, 30);
            lblMenuText.TabIndex = 2;
            lblMenuText.Text = "SPRINT 2";
            lblMenuText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpCustomer
            // 
            grpCustomer.Controls.Add(lblCustomerNumberTitle);
            grpCustomer.Controls.Add(lblNameTitle);
            grpCustomer.Controls.Add(lblContactTitle);
            grpCustomer.Controls.Add(txtCustomerNumber);
            grpCustomer.Controls.Add(txtName);
            grpCustomer.Controls.Add(txtContact);
            grpCustomer.Controls.Add(chkBankStaff);
            grpCustomer.Controls.Add(btnAdd);
            grpCustomer.Controls.Add(btnFind);
            grpCustomer.Controls.Add(btnUpdate);
            grpCustomer.Controls.Add(btnDelete);
            grpCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpCustomer.Location = new Point(175, 20);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Size = new Size(1000, 195);
            grpCustomer.TabIndex = 1;
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Customer";
            // 
            // lblCustomerNumberTitle
            // 
            lblCustomerNumberTitle.Font = new Font("Segoe UI", 10F);
            lblCustomerNumberTitle.Location = new Point(25, 37);
            lblCustomerNumberTitle.Name = "lblCustomerNumberTitle";
            lblCustomerNumberTitle.Size = new Size(170, 25);
            lblCustomerNumberTitle.TabIndex = 0;
            lblCustomerNumberTitle.Text = "Customer number";
            // 
            // lblNameTitle
            // 
            lblNameTitle.Font = new Font("Segoe UI", 10F);
            lblNameTitle.Location = new Point(230, 37);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new Size(100, 25);
            lblNameTitle.TabIndex = 1;
            lblNameTitle.Text = "Name";
            // 
            // lblContactTitle
            // 
            lblContactTitle.Font = new Font("Segoe UI", 10F);
            lblContactTitle.Location = new Point(495, 37);
            lblContactTitle.Name = "lblContactTitle";
            lblContactTitle.Size = new Size(100, 25);
            lblContactTitle.TabIndex = 2;
            lblContactTitle.Text = "Contact";
            // 
            // txtCustomerNumber
            // 
            txtCustomerNumber.Font = new Font("Segoe UI", 11F);
            txtCustomerNumber.Location = new Point(25, 66);
            txtCustomerNumber.Name = "txtCustomerNumber";
            txtCustomerNumber.Size = new Size(170, 32);
            txtCustomerNumber.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(230, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 32);
            txtName.TabIndex = 4;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 11F);
            txtContact.Location = new Point(495, 66);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(280, 32);
            txtContact.TabIndex = 5;
            // 
            // chkBankStaff
            // 
            chkBankStaff.Font = new Font("Segoe UI", 10F);
            chkBankStaff.Location = new Point(805, 68);
            chkBankStaff.Name = "chkBankStaff";
            chkBankStaff.Size = new Size(140, 28);
            chkBankStaff.TabIndex = 6;
            chkBankStaff.Text = "Bank Staff";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(30, 124, 124);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(25, 126);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 42);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.White;
            btnFind.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFind.Location = new Point(220, 126);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(170, 42);
            btnFind.TabIndex = 8;
            btnFind.Text = "Find Customer";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(247, 206, 72);
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.Location = new Point(415, 126);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(170, 42);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update Customer";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.Location = new Point(610, 126);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 42);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete Customer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // grpAccount
            // 
            grpAccount.Controls.Add(lblAccountTypeTitle);
            grpAccount.Controls.Add(cboAccountType);
            grpAccount.Controls.Add(lblAccountNumber);
            grpAccount.Controls.Add(lblBalance);
            grpAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpAccount.Location = new Point(175, 232);
            grpAccount.Name = "grpAccount";
            grpAccount.Size = new Size(445, 234);
            grpAccount.TabIndex = 2;
            grpAccount.TabStop = false;
            grpAccount.Text = "Account";
            // 
            // lblAccountTypeTitle
            // 
            lblAccountTypeTitle.Font = new Font("Segoe UI", 10F);
            lblAccountTypeTitle.Location = new Point(25, 42);
            lblAccountTypeTitle.Name = "lblAccountTypeTitle";
            lblAccountTypeTitle.Size = new Size(140, 25);
            lblAccountTypeTitle.TabIndex = 0;
            lblAccountTypeTitle.Text = "Account type";
            // 
            // cboAccountType
            // 
            cboAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAccountType.Font = new Font("Segoe UI", 11F);
            cboAccountType.Items.AddRange(new object[] { "Everyday Account", "Investment Account", "Omni Account" });
            cboAccountType.Location = new Point(25, 75);
            cboAccountType.Name = "cboAccountType";
            cboAccountType.Size = new Size(387, 33);
            cboAccountType.TabIndex = 1;
            cboAccountType.SelectedIndexChanged += cboAccountType_SelectedIndexChanged;
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAccountNumber.Location = new Point(25, 132);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(375, 27);
            lblAccountNumber.TabIndex = 2;
            lblAccountNumber.Text = "Account number: -";
            // 
            // lblBalance
            // 
            lblBalance.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBalance.Location = new Point(25, 177);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(375, 27);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "Balance: $0.00";
            // 
            // grpTransaction
            // 
            grpTransaction.Controls.Add(lblAmountTitle);
            grpTransaction.Controls.Add(txtAmount);
            grpTransaction.Controls.Add(btnDeposit);
            grpTransaction.Controls.Add(btnWithdraw);
            grpTransaction.Controls.Add(btnInterest);
            grpTransaction.Controls.Add(btnFee);
            grpTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpTransaction.Location = new Point(642, 232);
            grpTransaction.Name = "grpTransaction";
            grpTransaction.Size = new Size(533, 234);
            grpTransaction.TabIndex = 3;
            grpTransaction.TabStop = false;
            grpTransaction.Text = "Transaction";
            // 
            // lblAmountTitle
            // 
            lblAmountTitle.Font = new Font("Segoe UI", 10F);
            lblAmountTitle.Location = new Point(25, 42);
            lblAmountTitle.Name = "lblAmountTitle";
            lblAmountTitle.Size = new Size(140, 25);
            lblAmountTitle.TabIndex = 0;
            lblAmountTitle.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 11F);
            txtAmount.Location = new Point(25, 75);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(474, 32);
            txtAmount.TabIndex = 1;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.FromArgb(30, 124, 124);
            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(25, 131);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(145, 41);
            btnDeposit.TabIndex = 2;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnWithdraw.Location = new Point(187, 131);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(145, 41);
            btnWithdraw.TabIndex = 3;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnInterest
            // 
            btnInterest.BackColor = Color.FromArgb(247, 206, 72);
            btnInterest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInterest.Location = new Point(349, 131);
            btnInterest.Name = "btnInterest";
            btnInterest.Size = new Size(150, 41);
            btnInterest.TabIndex = 4;
            btnInterest.Text = "Add Interest";
            btnInterest.UseVisualStyleBackColor = false;
            btnInterest.Click += btnInterest_Click;
            // 
            // btnFee
            // 
            btnFee.Font = new Font("Segoe UI", 10F);
            btnFee.Location = new Point(349, 180);
            btnFee.Name = "btnFee";
            btnFee.Size = new Size(150, 36);
            btnFee.TabIndex = 5;
            btnFee.Text = "Apply Fee";
            btnFee.Click += btnFee_Click;
            // 
            // grpHistory
            // 
            grpHistory.Controls.Add(listHistory);
            grpHistory.Controls.Add(lblStatusTitle);
            grpHistory.Controls.Add(lblStatus);
            grpHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpHistory.Location = new Point(175, 485);
            grpHistory.Name = "grpHistory";
            grpHistory.Size = new Size(1000, 230);
            grpHistory.TabIndex = 4;
            grpHistory.TabStop = false;
            grpHistory.Text = "Transaction History";
            // 
            // listHistory
            // 
            listHistory.Font = new Font("Segoe UI", 10F);
            listHistory.HorizontalScrollbar = true;
            listHistory.ItemHeight = 23;
            listHistory.Location = new Point(25, 48);
            listHistory.Name = "listHistory";
            listHistory.Size = new Size(640, 142);
            listHistory.TabIndex = 0;
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.Font = new Font("Segoe UI", 10F);
            lblStatusTitle.Location = new Point(695, 47);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(110, 25);
            lblStatusTitle.TabIndex = 1;
            lblStatusTitle.Text = "Status";
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.FromArgb(232, 244, 243);
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(695, 79);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(275, 123);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Ready.";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1200, 750);
            Controls.Add(panelMenu);
            Controls.Add(grpCustomer);
            Controls.Add(grpAccount);
            Controls.Add(grpTransaction);
            Controls.Add(grpHistory);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banking App - Customer Management";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            grpAccount.ResumeLayout(false);
            grpTransaction.ResumeLayout(false);
            grpTransaction.PerformLayout();
            grpHistory.ResumeLayout(false);
            ResumeLayout(false);
        }

        private PictureBox pictureBoxLogo;
    }
}
