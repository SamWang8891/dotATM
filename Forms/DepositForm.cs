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

        private string currentUserAccount;
        private AccountService service = new AccountService();

        public DepositForm(string accountNumber)
        {
            InitializeComponent();
            currentUserAccount = accountNumber;
        }

        public void ShowBalance(object sender, EventArgs e)
        {
            int balance = service.GetBalance(currentUserAccount);
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

                bool result = service.Withdraw(currentUserAccount, amount);

                if (result)
                {
                    label3.Text = service.GetBalance(currentUserAccount).ToString();
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
    }
}
