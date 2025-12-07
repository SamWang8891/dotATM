using dotATM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotATM.Forms
{
    public partial class CreateAccountForm : Form
    {
        private AccountService _service;
        public CreateAccountForm(AccountService service)
        {
            InitializeComponent();
            _service = service;
            accountTextBox.ImeMode = ImeMode.Disable;
            passwordTextBox.ImeMode = ImeMode.Disable;
            recheckTextBox.ImeMode = ImeMode.Disable;

        }

        private bool IsPasswordValid(string input)
        {
            if (String.IsNullOrEmpty(input) || input.Length < 6)
            {
                label_warning.Text = "密碼長度必須至少為 6 個字元";
                passwordTextBox.Text = "";
                recheckTextBox.Text = "";
                return false;
            }

            //至少包含一個字母與一個數字
            if (!(Regex.IsMatch(input, @"\d") && Regex.IsMatch(input, @"[a-zA-Z]")))
            {
                label_warning.Text = "密碼必須同時包含至少一個英文字母和一個數字";
                passwordTextBox.Text = "";
                recheckTextBox.Text = "";
                return false;
            }

            return true;
        }

        private void keyPass_process(object sender, KeyPressEventArgs e)
        {
            char inputChar = e.KeyChar;
            string allowedSymbols = "#$-._@";

            // 允許：控制鍵 (如 Backspace) 或 英文/數字 或 在允許的符號列表中
            bool isAllowed = char.IsControl(inputChar) ||
                             char.IsLetterOrDigit(inputChar) ||
                             char.IsSymbol(inputChar) ||
                             allowedSymbols.Contains(inputChar);

            if (!isAllowed)
            {
                e.Handled = true;
            }
        }

        private void button_create_account_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(accountTextBox.Text))
            {
                label_warning.Text = "無效帳號輸入";
                return;
            }
            if (!IsPasswordValid(passwordTextBox.Text))
            {
                return;
            }
            if (passwordTextBox.Text != recheckTextBox.Text)
            {
                label_warning.Text = "密碼確認錯誤";
                passwordTextBox.Text = "";
                recheckTextBox.Text = "";
                return;
            }

            _service.CreateAccount(accountTextBox.Text, passwordTextBox.Text);

            MessageBox.Show("創建帳號成功!");
            this.DialogResult = DialogResult.OK;
            LoginForm loginForm = new LoginForm(_service);
            loginForm.Show();
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            LoginForm loginForm = new LoginForm(_service);
            loginForm.Show();
            this.Close();
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
