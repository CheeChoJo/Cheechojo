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
        static double price1 = 10;
        static double price2 = 20;
        static double price3 = 30;
        static double volume1 = 1;
        static double volume2 = 2;
        static double volume3 = 3;
        static double value1 = price1 * volume1;
        static double value2 = price2 * volume2;
        static double value3 = price3 * volume3;
        static double balance = 150;
        public Exchange()
        {
            InitializeComponent();
        }

        private void Exchange_Load(object sender, EventArgs e)
        {
            //testovací hodnoty, jednotlivým proměnám poté přiřadíme co stáhenme ze serveru
            //základní tabulka
            textBoxPrice1.Text = Convert.ToString(price1);
            textBoxPrice2.Text = Convert.ToString(price2);
            textBoxPrice3.Text = Convert.ToString(price3);
            textBoxVolume1.Text = Convert.ToString(volume1);
            textBoxVolume2.Text = Convert.ToString(volume2);
            textBoxVolume3.Text = Convert.ToString(volume3);
            textBoxValue1.Text = Convert.ToString(price1 * volume1);
            textBoxValue2.Text = Convert.ToString(price2 * volume2);
            textBoxValue3.Text = Convert.ToString(price3 * volume3);
            textBoxBalance.Text = Convert.ToString(balance)+ " €";
            textBoxAmountBS.Text = " ";
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

        private void timerExchange_Tick(object sender, EventArgs e)
        {
            price1 += 1;
            Exchange_Load(sender, e);
        }
    }
}
