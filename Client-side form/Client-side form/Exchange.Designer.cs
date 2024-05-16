namespace Client_side_form
{
    partial class Exchange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTicker = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelTicker1 = new System.Windows.Forms.Label();
            this.textBoxPrice1 = new System.Windows.Forms.TextBox();
            this.textBoxVolume1 = new System.Windows.Forms.TextBox();
            this.textBoxValue1 = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.radioButtonBuy = new System.Windows.Forms.RadioButton();
            this.radioButtonSell = new System.Windows.Forms.RadioButton();
            this.labelAmountBS = new System.Windows.Forms.Label();
            this.labelValueBS = new System.Windows.Forms.Label();
            this.buttonBuySell = new System.Windows.Forms.Button();
            this.labelTicker2 = new System.Windows.Forms.Label();
            this.labelTicker3 = new System.Windows.Forms.Label();
            this.textBoxPrice2 = new System.Windows.Forms.TextBox();
            this.textBoxPrice3 = new System.Windows.Forms.TextBox();
            this.textBoxVolume2 = new System.Windows.Forms.TextBox();
            this.textBoxVolume3 = new System.Windows.Forms.TextBox();
            this.textBoxValue2 = new System.Windows.Forms.TextBox();
            this.textBoxValue3 = new System.Windows.Forms.TextBox();
            this.textBoxAmountBS = new System.Windows.Forms.TextBox();
            this.textBoxValueBS = new System.Windows.Forms.TextBox();
            this.timerExchange = new System.Windows.Forms.Timer(this.components);
            this.listBoxExchange = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTicker
            // 
            this.labelTicker.AutoSize = true;
            this.labelTicker.Location = new System.Drawing.Point(50, 66);
            this.labelTicker.Name = "labelTicker";
            this.labelTicker.Size = new System.Drawing.Size(51, 20);
            this.labelTicker.TabIndex = 0;
            this.labelTicker.Text = "Ticker";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(201, 66);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(590, 66);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(50, 20);
            this.labelValue.TabIndex = 2;
            this.labelValue.Text = "Value";
            this.labelValue.Click += new System.EventHandler(this.labelValue_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(378, 66);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(63, 20);
            this.labelVolume.TabIndex = 3;
            this.labelVolume.Text = "Volume";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(446, 15);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(71, 20);
            this.labelBalance.TabIndex = 4;
            this.labelBalance.Text = "Balance:";
            // 
            // labelTicker1
            // 
            this.labelTicker1.AutoSize = true;
            this.labelTicker1.Location = new System.Drawing.Point(51, 132);
            this.labelTicker1.Name = "labelTicker1";
            this.labelTicker1.Size = new System.Drawing.Size(60, 20);
            this.labelTicker1.TabIndex = 5;
            this.labelTicker1.Text = "Ticker1";
            // 
            // textBoxPrice1
            // 
            this.textBoxPrice1.Enabled = false;
            this.textBoxPrice1.Location = new System.Drawing.Point(184, 132);
            this.textBoxPrice1.Name = "textBoxPrice1";
            this.textBoxPrice1.Size = new System.Drawing.Size(80, 26);
            this.textBoxPrice1.TabIndex = 6;
            // 
            // textBoxVolume1
            // 
            this.textBoxVolume1.Enabled = false;
            this.textBoxVolume1.Location = new System.Drawing.Point(362, 128);
            this.textBoxVolume1.Name = "textBoxVolume1";
            this.textBoxVolume1.Size = new System.Drawing.Size(98, 26);
            this.textBoxVolume1.TabIndex = 7;
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.Enabled = false;
            this.textBoxValue1.Location = new System.Drawing.Point(578, 128);
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.Size = new System.Drawing.Size(90, 26);
            this.textBoxValue1.TabIndex = 8;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Enabled = false;
            this.textBoxBalance.Location = new System.Drawing.Point(540, 12);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(126, 26);
            this.textBoxBalance.TabIndex = 9;
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.Location = new System.Drawing.Point(206, 491);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(61, 24);
            this.radioButtonBuy.TabIndex = 10;
            this.radioButtonBuy.TabStop = true;
            this.radioButtonBuy.Text = "Buy";
            this.radioButtonBuy.UseVisualStyleBackColor = true;
            // 
            // radioButtonSell
            // 
            this.radioButtonSell.AutoSize = true;
            this.radioButtonSell.Location = new System.Drawing.Point(206, 538);
            this.radioButtonSell.Name = "radioButtonSell";
            this.radioButtonSell.Size = new System.Drawing.Size(60, 24);
            this.radioButtonSell.TabIndex = 11;
            this.radioButtonSell.TabStop = true;
            this.radioButtonSell.Text = "Sell";
            this.radioButtonSell.UseVisualStyleBackColor = true;
            // 
            // labelAmountBS
            // 
            this.labelAmountBS.AutoSize = true;
            this.labelAmountBS.Location = new System.Drawing.Point(290, 452);
            this.labelAmountBS.Name = "labelAmountBS";
            this.labelAmountBS.Size = new System.Drawing.Size(65, 20);
            this.labelAmountBS.TabIndex = 12;
            this.labelAmountBS.Text = "Amount";
            // 
            // labelValueBS
            // 
            this.labelValueBS.AutoSize = true;
            this.labelValueBS.Location = new System.Drawing.Point(399, 452);
            this.labelValueBS.Name = "labelValueBS";
            this.labelValueBS.Size = new System.Drawing.Size(50, 20);
            this.labelValueBS.TabIndex = 13;
            this.labelValueBS.Text = "Value";
            // 
            // buttonBuySell
            // 
            this.buttonBuySell.Location = new System.Drawing.Point(530, 491);
            this.buttonBuySell.Name = "buttonBuySell";
            this.buttonBuySell.Size = new System.Drawing.Size(100, 40);
            this.buttonBuySell.TabIndex = 14;
            this.buttonBuySell.Text = "Buy/Sell";
            this.buttonBuySell.UseVisualStyleBackColor = true;
            // 
            // labelTicker2
            // 
            this.labelTicker2.AutoSize = true;
            this.labelTicker2.Location = new System.Drawing.Point(51, 208);
            this.labelTicker2.Name = "labelTicker2";
            this.labelTicker2.Size = new System.Drawing.Size(60, 20);
            this.labelTicker2.TabIndex = 15;
            this.labelTicker2.Text = "Ticker2";
            // 
            // labelTicker3
            // 
            this.labelTicker3.AutoSize = true;
            this.labelTicker3.Location = new System.Drawing.Point(51, 285);
            this.labelTicker3.Name = "labelTicker3";
            this.labelTicker3.Size = new System.Drawing.Size(60, 20);
            this.labelTicker3.TabIndex = 16;
            this.labelTicker3.Text = "Ticker3";
            // 
            // textBoxPrice2
            // 
            this.textBoxPrice2.Enabled = false;
            this.textBoxPrice2.Location = new System.Drawing.Point(183, 203);
            this.textBoxPrice2.Name = "textBoxPrice2";
            this.textBoxPrice2.Size = new System.Drawing.Size(80, 26);
            this.textBoxPrice2.TabIndex = 17;
            // 
            // textBoxPrice3
            // 
            this.textBoxPrice3.Enabled = false;
            this.textBoxPrice3.Location = new System.Drawing.Point(184, 283);
            this.textBoxPrice3.Name = "textBoxPrice3";
            this.textBoxPrice3.Size = new System.Drawing.Size(79, 26);
            this.textBoxPrice3.TabIndex = 18;
            // 
            // textBoxVolume2
            // 
            this.textBoxVolume2.Enabled = false;
            this.textBoxVolume2.Location = new System.Drawing.Point(366, 203);
            this.textBoxVolume2.Name = "textBoxVolume2";
            this.textBoxVolume2.Size = new System.Drawing.Size(94, 26);
            this.textBoxVolume2.TabIndex = 19;
            // 
            // textBoxVolume3
            // 
            this.textBoxVolume3.Enabled = false;
            this.textBoxVolume3.Location = new System.Drawing.Point(366, 286);
            this.textBoxVolume3.Name = "textBoxVolume3";
            this.textBoxVolume3.Size = new System.Drawing.Size(94, 26);
            this.textBoxVolume3.TabIndex = 20;
            // 
            // textBoxValue2
            // 
            this.textBoxValue2.Enabled = false;
            this.textBoxValue2.Location = new System.Drawing.Point(578, 202);
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(86, 26);
            this.textBoxValue2.TabIndex = 21;
            // 
            // textBoxValue3
            // 
            this.textBoxValue3.Enabled = false;
            this.textBoxValue3.Location = new System.Drawing.Point(578, 292);
            this.textBoxValue3.Name = "textBoxValue3";
            this.textBoxValue3.Size = new System.Drawing.Size(90, 26);
            this.textBoxValue3.TabIndex = 22;
            // 
            // textBoxAmountBS
            // 
            this.textBoxAmountBS.Location = new System.Drawing.Point(286, 505);
            this.textBoxAmountBS.Name = "textBoxAmountBS";
            this.textBoxAmountBS.Size = new System.Drawing.Size(68, 26);
            this.textBoxAmountBS.TabIndex = 23;
            // 
            // textBoxValueBS
            // 
            this.textBoxValueBS.Location = new System.Drawing.Point(392, 505);
            this.textBoxValueBS.Name = "textBoxValueBS";
            this.textBoxValueBS.Size = new System.Drawing.Size(68, 26);
            this.textBoxValueBS.TabIndex = 24;
            // 
            // timerExchange
            // 
            this.timerExchange.Enabled = true;
            this.timerExchange.Interval = 2500;
            this.timerExchange.Tick += new System.EventHandler(this.timerExchange_Tick);
            // 
            // listBoxExchange
            // 
            this.listBoxExchange.FormattingEnabled = true;
            this.listBoxExchange.ItemHeight = 20;
            this.listBoxExchange.Items.AddRange(new object[] {
            "Ticker1",
            "Ticker2",
            "Ticker3"});
            this.listBoxExchange.Location = new System.Drawing.Point(18, 491);
            this.listBoxExchange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxExchange.Name = "listBoxExchange";
            this.listBoxExchange.Size = new System.Drawing.Size(139, 64);
            this.listBoxExchange.TabIndex = 25;
            // 
            // Exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 612);
            this.Controls.Add(this.listBoxExchange);
            this.Controls.Add(this.textBoxValueBS);
            this.Controls.Add(this.textBoxAmountBS);
            this.Controls.Add(this.textBoxValue3);
            this.Controls.Add(this.textBoxValue2);
            this.Controls.Add(this.textBoxVolume3);
            this.Controls.Add(this.textBoxVolume2);
            this.Controls.Add(this.textBoxPrice3);
            this.Controls.Add(this.textBoxPrice2);
            this.Controls.Add(this.labelTicker3);
            this.Controls.Add(this.labelTicker2);
            this.Controls.Add(this.buttonBuySell);
            this.Controls.Add(this.labelValueBS);
            this.Controls.Add(this.labelAmountBS);
            this.Controls.Add(this.radioButtonSell);
            this.Controls.Add(this.radioButtonBuy);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.textBoxValue1);
            this.Controls.Add(this.textBoxVolume1);
            this.Controls.Add(this.textBoxPrice1);
            this.Controls.Add(this.labelTicker1);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTicker);
            this.Name = "Exchange";
            this.Text = "Exchange";
            this.Load += new System.EventHandler(this.Exchange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTicker;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelTicker1;
        private System.Windows.Forms.TextBox textBoxPrice1;
        private System.Windows.Forms.TextBox textBoxVolume1;
        private System.Windows.Forms.TextBox textBoxValue1;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.RadioButton radioButtonBuy;
        private System.Windows.Forms.RadioButton radioButtonSell;
        private System.Windows.Forms.Label labelAmountBS;
        private System.Windows.Forms.Label labelValueBS;
        private System.Windows.Forms.Button buttonBuySell;
        private System.Windows.Forms.Label labelTicker2;
        private System.Windows.Forms.Label labelTicker3;
        private System.Windows.Forms.TextBox textBoxPrice2;
        private System.Windows.Forms.TextBox textBoxPrice3;
        private System.Windows.Forms.TextBox textBoxVolume2;
        private System.Windows.Forms.TextBox textBoxVolume3;
        private System.Windows.Forms.TextBox textBoxValue2;
        private System.Windows.Forms.TextBox textBoxValue3;
        private System.Windows.Forms.TextBox textBoxAmountBS;
        private System.Windows.Forms.TextBox textBoxValueBS;
        private System.Windows.Forms.ListBox listBoxExchange;
        public System.Windows.Forms.Timer timerExchange;
    }
}