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
        private AccountService _service;
        public LoginForm()
        {
            InitializeComponent();
            _service = new AccountService(); 
            AccountInput.ImeMode = ImeMode.Disable;
            PasswordInput.ImeMode = ImeMode.Disable;
        }

        public LoginForm(AccountService service)
        {
            InitializeComponent();
            _service = service;
            AccountInput.ImeMode = ImeMode.Disable;
            PasswordInput.ImeMode = ImeMode.Disable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string account = AccountInput.Text;
            string password = PasswordInput.Text;
            bool isValid = false;

            if (AccountInput.Text == "" || PasswordInput.Text == "")
            {
                MessageBox.Show("請輸入帳號及密碼！");
            }

            
            isValid = _service.Login(account, password);
            if (isValid)
            {
                MessageBox.Show("登入成功！");
                MenuForm menu = new MenuForm(_service);
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤，請重試。");
            }
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccount = new CreateAccountForm(_service);
            createAccount.Show();
            this.Close();
        }
    }
}
