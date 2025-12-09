using dotATM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotATM.Forms
{
    public partial class TransferForm : Form
    {
        private AccountService _service;

        public TransferForm(AccountService service)
        {
            _service = service;
            InitializeComponent();
            label3.Text = _service.GetBalance().ToString();
            textBox1.ImeMode = ImeMode.Disable;
            textBox2.ImeMode = ImeMode.Disable;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string transferAccount = textBox1.Text;
            int transferAmount;
            if (!int.TryParse(textBox2.Text, out transferAmount))
            {
                MessageBox.Show("請輸入正確金額!");
            }
            int result = _service.Transfer(transferAccount, transferAmount);
            if (result == 0)
            {
                MessageBox.Show("轉帳成功!");
            }
            else if (result == 1)
            {
                MessageBox.Show("餘額不足!");
            }
            else if (result == 2)
            {
                MessageBox.Show("目標帳戶不存在!");
            }
            else if (result == 3)
            {
                MessageBox.Show("請勿轉帳給自己!");
            }
            label3.Text = _service.GetBalance().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(_service);
            menuForm.Show();
            this.Close();
        }
    }
}
