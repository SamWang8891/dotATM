using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotATM.Services;

namespace dotATM.Forms
{
    public partial class LoginForm : Form
    {
        private AccountService _accountService;
        public LoginForm()
        {
            _accountService = new AccountService();
            InitializeComponent();
            _accountService.CreateAccount("a", "a");
            AccountInput.ImeMode = ImeMode.Disable;
            PasswordInput.ImeMode = ImeMode.Disable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = AccountInput.Text;
            string password = PasswordInput.Text;
            bool isValid = _accountService.VerifyPassword(account, password);

            if (isValid)
            {
                MessageBox.Show("登入成功！");
                MenuForm menu = new MenuForm(account);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤，請重試。");
            }
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccount = new CreateAccountForm();
            createAccount.Show();
            this.Hide();
        }
    }
}
