﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_side_form
{
    public class _Account
    {
        public string userName { get; set; }
        public string password { get; set; }
        public double balance { get; set; }
        public int volume1 { get; set; }
        public int volume2 { get; set; }
        public int volume3 { get; set; }
        public int buyOrSell { get; set; }
        public int buySellVolume { get; set; }
        public int tickerSelected { get; set; }
        public int priceWhenSelling { get; set; }

        public void LoadN(string username)
        {

        }
        public void LoadBVVV(int Balance,int Volume1,int Volume2,int Volume3)
        {

        }
    }
}
