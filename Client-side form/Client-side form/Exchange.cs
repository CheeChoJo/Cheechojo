using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_side_form
{
    public partial class Exchange : Form
    {
        static double price1;
        static double price2;
        static double price3;
        static int volume1 = 1;
        static int volume2 = 2;
        static int volume3 = 3;
        static int buySell;
        static int amount;
        static double valueBS;
        static Random rnd = new Random();
        public _Account account = new _Account();
        public string serverUrl { get; set; }

        public Exchange()
        {
            InitializeComponent();
            textBoxAmountBS.Text = "1";
            textBoxValueBS.Text = "0 €";
            timerExchange.Start();
            UpdateAccountInfo(); // Initialize the account info when the form loads
        }

        private async void BuySell()
        {
            if (radioButtonBuy.Checked)
            {
                buySell = 1; //buy
            }
            else if (radioButtonSell.Checked)
            {
                buySell = 0;
            }
            using (var client = new HttpClient())
            {
                int.TryParse(textBoxAmountBS.Text, out amount);
                switch (listBoxExchange.SelectedIndex)
                {
                    case 0:
                        valueBS = price1 * amount;
                        break;
                    case 1:
                        valueBS = price2 * amount;
                        break;
                    case 2:
                        valueBS = price3 * amount;
                        break;
                }
                if (buySell == 1) // Buy
                {
                    account.balance -= valueBS;
                }
                else // Sell
                {
                    account.balance += valueBS;
                }

                switch (listBoxExchange.SelectedIndex)
                {
                    case 0:
                        account.volume1 = buySell == 1 ? account.volume1 + amount: account.volume1 - amount;
                        break;
                    case 1:
                        account.volume2 = buySell == 1 ? account.volume2 + amount: account.volume2 - amount;
                        break;
                    case 2:
                        account.volume3 = buySell == 1 ? account.volume3 + amount: account.volume3 - amount;
                        break;
                    default:
                        MessageBox.Show("Invalid selection.");
                        return;
                }

                var url = serverUrl + "/change";
                var dataToSend = new
                {
                    userName = account.userName,
                    password = account.password,
                    balance = account.balance,
                    buySell = buySell,
                    volume1 = account.volume1,
                    volume2 = account.volume2,
                    volume3 = account.volume3,
                    tickerSelected = listBoxExchange.SelectedIndex,
                };
                var json = JsonConvert.SerializeObject(dataToSend);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;

                try
                {
                    response = await client.PostAsync(url, content);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        account = JsonConvert.DeserializeObject<_Account>(responseContent);
                        MessageBox.Show($"New Balance: {account.balance}");
                        UpdateAccountInfo();
                    }
                    else
                    {
                        MessageBox.Show("Transaction failed. Response: " + responseContent); // Log the response for debugging
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        private async Task FetchPrices()
        {
            using (var client = new HttpClient())
            {
                string usefulUrl = serverUrl + "/";
                var url = usefulUrl;
                HttpResponseMessage response = null;

                try
                {
                    response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var priceData = JsonConvert.DeserializeObject<dynamic>(responseContent);

                        price1 = priceData.sotowebVal;
                        price2 = priceData.bakalariVal;
                        price3 = priceData.betbotVal;

                        UpdatePrices();
                    }
                    else
                    {
                        MessageBox.Show("Failed to fetch prices.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error number 2 occurred: {ex.Message}");
                }
            }
        }

        private void UpdatePrices()
        {
            double lastPrice1 = ParseDoubleSafe(textBoxPrice1.Text);
            double lastPrice2 = ParseDoubleSafe(textBoxPrice2.Text);
            double lastPrice3 = ParseDoubleSafe(textBoxPrice3.Text);

            textBoxPrice1.Text = $"{price1} €";
            textBoxPrice2.Text = $"{price2} €";
            textBoxPrice3.Text = $"{price3} €";

            double difference1 = lastPrice1 - price1;
            double difference2 = lastPrice2 - price2;
            double difference3 = lastPrice3 - price3;

            Color positiveChangeColor = ColorTranslator.FromHtml("#d91143");
            Color negativeChangeColor = Color.LightGreen;
            Color noChangeColor = Color.Pink;

            textBoxPrice1.BackColor = difference1 < 0 ? negativeChangeColor : (difference1 > 0 ? positiveChangeColor : noChangeColor);
            textBoxPrice2.BackColor = difference2 < 0 ? negativeChangeColor : (difference2 > 0 ? positiveChangeColor : noChangeColor);
            textBoxPrice3.BackColor = difference3 < 0 ? negativeChangeColor : (difference3 > 0 ? positiveChangeColor : noChangeColor);

            UpdateAccountInfo();
            UpdateValues();
        }

        private double ParseDoubleSafe(string text)
        {
            double result;
            var cleanedText = text.Replace(" €", "").Trim();
            if (double.TryParse(cleanedText, out result))
            {
                return result;
            }
            return 0; // Default value if parsing fails
        }

        private void UpdateAccountInfo()
        {
            textBoxVolume1.Text = Convert.ToString(account.volume1);
            textBoxVolume2.Text = Convert.ToString(account.volume2);
            textBoxVolume3.Text = Convert.ToString(account.volume3);
            textBoxBalance.Text = $"{account.balance} €";
            textBoxUser.Text = account.userName;
            UpdateValues();
        }

        private void UpdateValues()
        {
            textBoxValue1.Text = $"{price1 * account.volume1} €";
            textBoxValue2.Text = $"{price2 * account.volume2} €";
            textBoxValue3.Text = $"{price3 * account.volume3} €";
            textBoxSum.Text = $"{price1 * account.volume1 + price2 * account.volume2 + price3 * account.volume3} €";
            int.TryParse(textBoxAmountBS.Text, out amount);
            switch (listBoxExchange.SelectedIndex)
            {
                case 0:
                    valueBS = price1 * amount;
                        break;
                case 1:
                    valueBS = price2 * amount;
                    break;
                case 2:
                    valueBS = price3 * amount;
                    break;
            }
            textBoxValueBS.Text = $"{valueBS} €";
        }

        private async void timerExchange_Tick(object sender, EventArgs e)
        {
            await FetchPrices();
        }

        private void buttonBuySell_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBoxAmountBS.Text, out amount))
            {
                switch (listBoxExchange.SelectedIndex)
                {
                    case 0:
                        valueBS = price1 * amount;
                        break;
                    case 1:
                        valueBS = price2 * amount;
                        break;
                    case 2:
                        valueBS = price3 * amount;
                        break;
                    default:
                        valueBS = 0;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Enter a valid amount.");
                return;
            }
            if (buySell == 1)
            {
                if (account.balance < valueBS)
                {
                    MessageBox.Show("Insufficient balance.");
                }
                else
                {
                    BuySell();
                }
            }
            else
            {
                switch (listBoxExchange.SelectedIndex)
                {
                    case 0:
                        if (account.volume1 < amount)
                        {
                            MessageBox.Show("Insufficient volume to sell.");
                        }
                        else
                        {
                            BuySell();
                        }
                        break;
                    case 1:
                        if (account.volume2 < amount)
                        {
                            MessageBox.Show("Insufficient volume to sell.");
                        }
                        else
                        {
                            BuySell();
                        }
                        break;
                    case 2:
                        if (account.volume3 < amount)
                        {
                            MessageBox.Show("Insufficient volume to sell.");
                        }
                        else
                        {
                            BuySell();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void radioButtonBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBuy.Checked)
            {
                buySell = 1; //buy
            }
            UpdateValues();
        }

        private void radioButtonSell_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSell.Checked)
            {
                buySell = 0;
            }
            UpdateValues();
        }

        private void buttonDetails1_Click(object sender, EventArgs e)
        {
            Details1 details1 = new Details1(this);
            details1.Show();
            this.Hide();
        }

        private void buttonDetails2_Click(object sender, EventArgs e)
        {
            Details2 details2 = new Details2(this);
            details2.Show();
            this.Hide();
        }

        private void buttonDetails3_Click(object sender, EventArgs e)
        {
            Details3 details3 = new Details3(this);
            details3.Show();
            this.Hide();
        }

        private void textBoxPrice3_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelValue_Click(object sender, EventArgs e)
        {
        }

        private void Exchange_Load(object sender, EventArgs e)
        {
            UpdateAccountInfo();
            int update = rnd.Next(1, 4);
            switch (update)
            {
                case 1:
                    price1 += 1;
                    break;
                case 2:
                    price2 += 1;
                    break;
                case 3:
                    price3 += 1;
                    break;
            }
        }

        private void listBoxExchange_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=xvFZjo5PgG0");
            account.balance += 1;
            BuySell();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}