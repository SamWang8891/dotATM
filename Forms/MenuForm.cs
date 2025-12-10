using dotATM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotATM.Forms
{
    public partial class MenuForm : Form
    {
        private AccountService _service;

        public MenuForm(AccountService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm(_service);
            withdrawForm.Show();
            this.Close();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(_service);
            depositForm.Show();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransferForm transForm = new TransferForm(_service);
            transForm.Show();
        private void borrowButton_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm(_service);
            borrowForm.Show();
            this.Close();
        }

        private void repayButton_Click(object sender, EventArgs e)
        {
            RepayForm repayForm = new RepayForm(_service);
            repayForm.Show();
            this.Close();
        }
    }
}
