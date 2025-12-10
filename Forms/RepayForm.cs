using dotATM.Services;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class RepayForm : Form
    {

        private AccountService _service;
        public RepayForm(AccountService service)
        {
            InitializeComponent();
            _service = service;
        }

        public void ShowBalance(object sender, EventArgs e)
        {
            int balance = _service.GetLoan();
            label3.Text = balance.ToString();
        }

        private void repayButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int amount))
            {
                MessageBox.Show("金額輸入錯");
                return;
            }

            if (_service.Repay(amount))
            {
                MessageBox.Show("還款成功");
            }
            else
            {
                MessageBox.Show("還款失敗（餘額不足或無欠款）");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(_service);
            menuForm.Show();
            this.Close();
        }
    }
}
