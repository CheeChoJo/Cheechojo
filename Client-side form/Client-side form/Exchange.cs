using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_side_form
{
    public partial class Exchange : Form
    {
        public Exchange()
        {
            InitializeComponent();
        }

        private void Exchange_Load(object sender, EventArgs e)
        {
            //testovací hodnoty, jednotlivým proměnám poté přiřadíme co stáhenme ze serveru
            //základní tabulka
            double price1 = 10;
            double price2 = 20;
            double price3 = 30;
            double volume1 = 1;
            double volume2 = 2;
            double volume3 = 3;
            double value1 = price1 * volume1;
            double value2 = price2 * volume2;
            double value3 = price3 * volume3;
            double balance = 150;
            double Amount = Convert.ToDouble(textBoxAmountBS.Text);
            double ValueBS = Convert.ToDouble(textBoxValueBS.Text);
            textBoxPrice1.Text = Convert.ToString(price1);
            textBoxPrice2.Text = Convert.ToString(price2);
            textBoxPrice3.Text = Convert.ToString(price3);
            textBoxVolume1.Text = Convert.ToString(volume1);
            textBoxVolume2.Text = Convert.ToString(volume2);
            textBoxVolume3.Text = Convert.ToString(volume3);
            textBoxValue1.Text = Convert.ToString(value1);
            textBoxValue2.Text = Convert.ToString(value2);
            textBoxValue3.Text = Convert.ToString(value3);
            textBoxBalance.Text = Convert.ToString(balance)+ " €";
            //nakupovací okénko
            int TickerSelected = listBoxExchange.SelectedIndex;
            switch (TickerSelected)
            {
                case 0:
                    
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void labelValue_Click(object sender, EventArgs e)
        {

        }

        private void timerExvhange_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
