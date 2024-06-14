using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Client_side_form
{
    public partial class Exchange : Form
    {
        static double price1 = 10;
        static double price2 = 20;
        static double price3 = 30;
        static int volume1 = 1;
        static int volume2 = 2;
        static int volume3 = 3;
        static double balanceOperative = 150;
        static int buySell;
        static int Amount;
        static double valueBS;
        static Random rnd = new Random();
        public _Account account = new _Account();
        public Exchange()
        {
            InitializeComponent();
            textBoxAmountBS.Text = " ";
            textBoxValueBS.Text = "0 €";
        }

        private async void BuySell()
        {
            using (var client = new HttpClient())
            {
                var url = "http://192.168.43.31:7142/change";
                var dataToSend = new
                {
                    accountName = account.userName,
                    password = account.password,
                    buySell = buySell,
                    volume1 = volume1,
                    volume2 = volume2,
                    volume3 = volume3,
                };
                var json = JsonConvert.SerializeObject(dataToSend);
                var content = new StringContent(json, Encoding.UTF8, "application/json"); //tohle bylo zmeneno experimentalne originally to bylo accountNsmr + ".json"
                HttpResponseMessage response = null;
                try
                {
                    response = await client.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        switch (buySell)
                        {
                            case 0: // sell
                                    // Implementujte logiku pro prodej zde
                                break;
                            case 1: // buy
                                var responseContent = await response.Content.ReadAsStringAsync();
                                account = JsonConvert.DeserializeObject<_Account>(responseContent);
                                MessageBox.Show(Convert.ToString(account.balance));
                                balanceOperative = account.balance;
                                break;
                            default:
                                MessageBox.Show("1Di0T error");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("PEBCAK Error!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Došlo k chybě: {ex.Message}");
                }
            }
        }
        private void Exchange_Load(object sender, EventArgs e)
        {
            textBoxPrice1.Text = Convert.ToString(price1) + " €";
            textBoxPrice2.Text = Convert.ToString(price2) + " €";
            textBoxPrice3.Text = Convert.ToString(price3) + " €";
            textBoxVolume1.Text = Convert.ToString(volume1);
            textBoxVolume2.Text = Convert.ToString(volume2);
            textBoxVolume3.Text = Convert.ToString(volume3);
            textBoxValue1.Text = Convert.ToString(price1 * volume1) + " €";
            textBoxValue2.Text = Convert.ToString(price2 * volume2) + " €";
            textBoxValue3.Text = Convert.ToString(price3 * volume3) + " €";
            textBoxBalance.Text = Convert.ToString(balanceOperative) + " €";
            textBoxSum.Text = Convert.ToString(price1*volume1 + price2*volume2+price3*volume3) + " €";
            textBoxUser.Text = Convert.ToString(account.userName);
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

        private void labelValue_Click(object sender, EventArgs e)
        {

        }

        private void timerExchange_Tick(object sender, EventArgs e)
        {
            //testovací hodnoty, jednotlivým proměnám poté přiřadíme co stáhenme ze serveru
            //základní tabulka            
            if(Int32.TryParse(textBoxAmountBS.Text, out Amount)) //řeší, když je Amount prázdný po zapnutí
            {
                switch (listBoxExchange.SelectedIndex)
                {
                    case 0:
                        textBoxValueBS.Text = (price1 * Amount).ToString() + " €";
                        break;
                    case 1:
                        textBoxValueBS.Text = (price2 * Amount).ToString() + " €";
                        break;
                    case 2:
                        textBoxValueBS.Text = (price3 * Amount).ToString() + " €";
                        break;
                    default:
                        textBoxValueBS.Text = "0 €";
                        break;
                }
            }
            else
            {
                textBoxValueBS.Text = "0 €";
            }
            Exchange_Load(this, e);
        }

        private void buttonBuySell_Click(object sender, EventArgs e)
        {
            //nakupovací okénko
            if (Int32.TryParse(textBoxAmountBS.Text, out Amount))
            {
                switch (listBoxExchange.SelectedIndex)
                {
                    case 0:
                        valueBS = price1 * Amount;
                        break;
                    case 1:
                        valueBS = price2 * Amount;
                        break;
                    case 2:
                        valueBS = price3 * Amount;
                        break;
                    default:
                        valueBS = 0;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Zadejte platnou částku.");
                return;
            }

            switch (listBoxExchange.SelectedIndex)//za tuhle nádhernou prasárnu může čermák, na mě nekoukejte -isa:3
            {
                case 0:
                    if (buySell == 1)
                    {
                        if (balanceOperative < valueBS)
                        {
                            MessageBox.Show("Na vašem investičním účtě nemáte dostatek prostředků.");
                        }
                        else
                        {
                            BuySell();
                        }
                    }
                    else
                    {
                        if (volume1 < Amount)
                        {
                            MessageBox.Show("Nedostatečný objem k prodeji.");
                        }
                        else
                        {
                            BuySell();
                        }
                    }
                    break;
                case 1:
                    if (buySell== 1)
                    {
                        if (balanceOperative < valueBS)
                        {
                            MessageBox.Show("Na vašem investičním účtě nemáte dostatek prostředků.");
                        }
                        else
                        {
                            volume2 += Amount;
                            balanceOperative -= valueBS;
                        }
                    }
                    else
                    {
                        if (volume2 < Amount)
                        {
                            MessageBox.Show("Nedostatečný objem k prodeji.");
                        }
                        else
                        {
                            volume2 -= Amount;
                            balanceOperative += valueBS;
                        }
                    }
                    break;
                case 2:
                    if (buySell== 1)
                    {
                        if (balanceOperative < valueBS)
                        {
                            MessageBox.Show("Na vašem investičním účtě nemáte dostatek prostředků.");
                        }
                        else
                        {
                            volume3 += Amount;
                            balanceOperative -= valueBS;
                        }
                    }
                    else
                    {
                        if (volume3 < Amount)
                        {
                            MessageBox.Show("Nedostatečný objem k prodeji.");
                        }
                        else
                        {
                            volume3 -= Amount;
                            balanceOperative += valueBS;
                        }
                    }
                    break;
                default:
                    break;
            }
            textBoxBalance.Text = balanceOperative.ToString() + " €";
        }

        private void radioButtonBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBuy.Checked)
            {
                buySell = 1;
            }
            else
            {
                buySell = 0;
            }
            
        }

        private void radioButtonSell_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDetails1_Click(object sender, EventArgs e)
        {
            Form Details1 = new Details1();
            Details1.Show();
            this.Hide();
        }

        private void buttonDetails2_Click(object sender, EventArgs e)
        {
            Form Details2 = new Details2();
            Details2.Show();
            this.Hide();
        }

        private void buttonDetails3_Click(object sender, EventArgs e)
        {            Form Details3 = new Details3();
            Details3.Show();
            this.Hide();
        }

        private void textBoxPrice3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//komentuju hihi
//cermakovi blbne git
//už zase 
