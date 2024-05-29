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

namespace Client_side_form
{
    public partial class Exchange : Form
    {
        static double price1 = 10;
        static double price2 = 20;
        static double price3 = 30;
        static double volume1 = 1;
        static double volume2 = 2;
        static double volume3 = 3;
        static double balance = 150;
        static int buySell;
        static double Amount;
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
                var response = await client.GetAsync("http://194.108.31.75:7142");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    account = JsonConvert.DeserializeObject<_Account>(content);
                    //string output = JsonConvert.SerializeObject(deserialisedProduct);
                    MessageBox.Show(Convert.ToString(account.balance));                            //test deserializace
                    balance = account.balance;
                    switch (buySell)
                    {
                        case 0: //sell
                            
                            break;
                        case 1: //buy
                            break;
                        default:
                            break;
                    }                    
                }
                else
                {
                    MessageBox.Show("PEBCAK Error!!!");
                    //System.Diagnostics.Process.Start("Shutdown", "-s -t 10");
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
            textBoxBalance.Text = Convert.ToString(balance) + " €";
            textBoxSum.Text = Convert.ToString(price1*volume1 + price2*volume2+price3*volume3) + " €";
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
            if(double.TryParse(textBoxAmountBS.Text, out Amount)) //řeší, když je Amount prázdný po zapnutí
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
            if (double.TryParse(textBoxAmountBS.Text, out Amount))
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
                        if (balance < valueBS)
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
                        if (balance < valueBS)
                        {
                            MessageBox.Show("Na vašem investičním účtě nemáte dostatek prostředků.");
                        }
                        else
                        {
                            volume2 += Amount;
                            balance -= valueBS;
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
                            balance += valueBS;
                        }
                    }
                    break;
                case 2:
                    if (buySell== 1)
                    {
                        if (balance < valueBS)
                        {
                            MessageBox.Show("Na vašem investičním účtě nemáte dostatek prostředků.");
                        }
                        else
                        {
                            volume3 += Amount;
                            balance -= valueBS;
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
                            balance += valueBS;
                        }
                    }
                    break;
                default:
                    break;
            }
            textBoxBalance.Text = balance.ToString() + " €";
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
