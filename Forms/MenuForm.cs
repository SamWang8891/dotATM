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
        private string currentUserAccount = "";
        public MenuForm(string currentUserAccount)
        {
            InitializeComponent();
            this.currentUserAccount = currentUserAccount;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm(currentUserAccount);
            withdrawForm.Show();
            this.Hide();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(currentUserAccount);
            depositForm.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }
    }
}
