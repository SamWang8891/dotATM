using dotATM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotATM.Forms
{
    public partial class ForeignExchangeForm : Form
    {
        private Button currentButton;
        private Color activeColor = Color.FromArgb(155, 155, 155);
        private Color defaultColor = Color.FromArgb(255, 255, 255);
        private string currentCurrencyCode;

        decimal totalTwd = 0;
        ExchangeRates rates;
        private const string api_url = "https://tw.rter.info/capi.php";

        private AccountService _service;
        public ForeignExchangeForm(AccountService service)
        {
            InitializeComponent();
            _service = service;
            pictureBox_cn.Parent = button_cn;
            pictureBox_cn.Location = new Point(pictureBox_cn.Location.X - button_cn.Location.X, pictureBox_cn.Location.Y - button_cn.Location.Y);
            pictureBox_us.Parent = button_us;
            pictureBox_us.Location = new Point(pictureBox_us.Location.X - button_us.Location.X, pictureBox_us.Location.Y - button_us.Location.Y);
            pictureBox_eu.Parent = button_eu;
            pictureBox_eu.Location = new Point(pictureBox_eu.Location.X - button_eu.Location.X, pictureBox_eu.Location.Y - button_eu.Location.Y);
            pictureBox_jp.Parent = button_jp;
            pictureBox_jp.Location = new Point(pictureBox_jp.Location.X - button_jp.Location.X, pictureBox_jp.Location.Y - button_jp.Location.Y);

            currentButton = button_jp;
            ActivateButton(button_jp);
            GetRate();
        }

        private async void GetRate()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    label_current_rate.Text = "查詢中，請稍候";
                    HttpResponseMessage response = await client.GetAsync(api_url);
                    response.EnsureSuccessStatusCode();

                    // 取得 JSON 字串
                    string json = await response.Content.ReadAsStringAsync();

                    rates = JsonSerializer.Deserialize<ExchangeRates>(json);

                    if (rates != null
                        && rates.ContainsKey("USDTWD")
                        && rates.ContainsKey("USDJPY")
                        && rates.ContainsKey("USDCNY")
                        && rates.ContainsKey("USDEUR"))
                    {
                        label_current_rate.Text = "目前匯率";
                        currentCurrencyCode = "JPY";
                        UpdateDisplay("JPY");
                        UpdateQuickButtons("JPY");
                    }
                }
                catch (Exception ex)
                {
                    label_current_rate.Text = $"服務暫停";
                    groupBox2.Hide();
                }
            }
        }

        public class RateDetail
        {
            [JsonPropertyName("Exrate")]
            public decimal Exrate { get; set; }

            [JsonPropertyName("UTC")]
            public string UTC { get; set; }
        }
        public class ExchangeRates : Dictionary<string, RateDetail> { }

        private void UpdateDisplay(string targetCurrencyCode)
        {
            if (rates == null || !rates.ContainsKey("USDTWD")) return;

            decimal usdToTwd = rates["USDTWD"].Exrate;
            decimal usdToTarget = 1.0m;
            string currencyName = "🇺🇸 美元 (USD)";


            if (targetCurrencyCode != "USD")
            {
                // 組合 Key，例如 USDJPY
                string key = "USD" + targetCurrencyCode;
                if (rates.ContainsKey(key))
                {
                    usdToTarget = rates[key].Exrate;
                }
            }

            decimal targetToTwd = usdToTwd / usdToTarget;
            decimal twdToTarget = usdToTarget / usdToTwd;

            // 設定幣別名稱
            switch (targetCurrencyCode)
            {
                case "USD": currencyName = "美元 USD"; break;
                case "JPY": currencyName = "日圓 JPY"; break;
                case "CNY": currencyName = "人民幣 CNY"; break;
                case "EUR": currencyName = "歐元 EUR"; break;
            }
            label_currency_name.Text = currencyName;

            label_exchange_rate.Text = $"1 {targetCurrencyCode} ≈ {targetToTwd:N4} TWD";
            label_reverse_rate.Text = $"1 TWD ≈ {twdToTarget:N4} {targetCurrencyCode}";
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                // 恢復前一個按鍵顏色
                if (currentButton != null)
                {
                    currentButton.BackColor = defaultColor;
                }

                currentButton = (Button)btnSender;
                currentButton.BackColor = activeColor;
            }
        }
        private void UpdateQuickButtons(string currency)
        {
            // 清空輸入框 (切換幣別時重置)
            textBox_target.Text = "";

            switch (currency)
            {
                case "USD":
                case "EUR":
                    SetButtonText("100", "300", "500", "1,000");
                    btnOption1.Tag = 100;
                    btnOption2.Tag = 300;
                    btnOption3.Tag = 500;
                    btnOption4.Tag = 1000;
                    break;

                case "JPY":
                    SetButtonText("10,000", "30,000", "50,000", "100,000");
                    btnOption1.Tag = 10000;
                    btnOption2.Tag = 30000;
                    btnOption3.Tag = 50000;
                    btnOption4.Tag = 100000;
                    break;

                case "CNY":
                    SetButtonText("1,000", "2,000", "3,000", "5,000");
                    btnOption1.Tag = 1000;
                    btnOption2.Tag = 2000;
                    btnOption3.Tag = 3000;
                    btnOption4.Tag = 5000;
                    break;
            }
        }
        private void SetButtonText(string t1, string t2, string t3, string t4)
        {
            btnOption1.Text = t1;
            btnOption2.Text = t2;
            btnOption3.Text = t3;
            btnOption4.Text = t4;
        }

        private void button_jp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            currentCurrencyCode = "JPY";
            UpdateDisplay("JPY");
            UpdateQuickButtons("JPY");
        }

        private void button_cn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            currentCurrencyCode = "CNY";
            UpdateDisplay("CNY");
            UpdateQuickButtons("CNY");
        }

        private void button_us_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            currentCurrencyCode = "USD";
            UpdateDisplay("USD");
            UpdateQuickButtons("USD");
        }

        private void button_eu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            currentCurrencyCode = "EUR";
            UpdateDisplay("EUR");
            UpdateQuickButtons("EUR");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnQuickAmount_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            if (clickedBtn != null && clickedBtn.Tag != null)
            {
                decimal currentVal = 0;
                decimal.TryParse(textBox_target.Text, out currentVal);
                currentVal += Convert.ToDecimal(clickedBtn.Tag);
                textBox_target.Text = currentVal.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_target_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {

            if (!decimal.TryParse(textBox_target.Text, out decimal foreignAmount))
            {
                label_deduct.Text = "0";
                return;
            }


            if (rates == null || !rates.ContainsKey("USDTWD"))
            {
                label_deduct.Text = "";
                textBox_target.Text = "";
                MessageBox.Show("匯率查詢中，請稍等");
                return;
            }
            decimal usdToTwd = rates["USDTWD"].Exrate;
            decimal usdToTarget = 1.0m;

            string targetKey = "USD" + currentCurrencyCode;
            if (currentCurrencyCode != "USD" && rates.ContainsKey(targetKey))
            {
                usdToTarget = rates[targetKey].Exrate;
            }

            decimal rate = usdToTwd / usdToTarget;
            totalTwd = foreignAmount * rate;

            // N0 代表不顯示小數點
            label_deduct.Text = $"{totalTwd:N0}";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            totalTwd = 0;
            textBox_target.Clear();
        }

        private void button_withdraw_Click(object sender, EventArgs e)
        {
            if (totalTwd > 0)
            {
                bool result = _service.Withdraw(Convert.ToInt32(totalTwd));
                if (result)
                {
                    MessageBox.Show("提款成功"); ;
                }
                else
                {
                    MessageBox.Show("提款失敗，餘額不足或金額錯誤");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(_service);
            menuForm.Show();
            this.Close();
        }
    }
}
