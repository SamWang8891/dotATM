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
    public partial class DepositForm : Form
    {
        private AccountService _service;

        public DepositForm(AccountService service)
        {
            InitializeComponent();
            _service = service;
        }

        public void ShowBalance(object sender, EventArgs e)
        {
            int balance = _service.GetBalance();
            label3.Text = balance.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox1.Text, out int amount))
                {
                    MessageBox.Show("請輸入正確金額");
                    return;
                }

                bool result = _service.Deposit(amount);

                if (result)
                {
                    label3.Text = _service.GetBalance().ToString();
                }
                else
                {
                    MessageBox.Show("存款失敗，餘額不足或金額錯誤");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                bool result = _service.Deposit(1000);

                if (result)
                {
                    label3.Text = _service.GetBalance().ToString();
                }
                else
                {
                    MessageBox.Show("錯誤");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                bool result = _service.Deposit(5000);

                if (result)
                {
                    label3.Text = _service.GetBalance().ToString();
                }
                else
                {
                    MessageBox.Show("錯誤");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                bool result = _service.Deposit(10000);

                if (result)
                {
                    label3.Text = _service.GetBalance().ToString();
                }
                else
                {
                    MessageBox.Show("錯誤");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
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
