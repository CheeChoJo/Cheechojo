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
            this.labelRovn = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDetails1 = new System.Windows.Forms.Button();
            this.buttonDetails2 = new System.Windows.Forms.Button();
            this.buttonDetails3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTicker
            // 
            this.labelTicker.AutoSize = true;
            this.labelTicker.Location = new System.Drawing.Point(76, 55);
            this.labelTicker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTicker.Name = "labelTicker";
            this.labelTicker.Size = new System.Drawing.Size(37, 13);
            this.labelTicker.TabIndex = 0;
            this.labelTicker.Text = "Ticker";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(177, 55);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(436, 55);
            this.labelValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(34, 13);
            this.labelValue.TabIndex = 2;
            this.labelValue.Text = "Value";
            this.labelValue.Click += new System.EventHandler(this.labelValue_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(295, 55);
            this.labelVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(42, 13);
            this.labelVolume.TabIndex = 3;
            this.labelVolume.Text = "Volume";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(340, 22);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(49, 13);
            this.labelBalance.TabIndex = 4;
            this.labelBalance.Text = "Balance:";
            // 
            // labelTicker1
            // 
            this.labelTicker1.AutoSize = true;
            this.labelTicker1.Location = new System.Drawing.Point(77, 98);
            this.labelTicker1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTicker1.Name = "labelTicker1";
            this.labelTicker1.Size = new System.Drawing.Size(43, 13);
            this.labelTicker1.TabIndex = 5;
            this.labelTicker1.Text = "Ticker1";
            // 
            // textBoxPrice1
            // 
            this.textBoxPrice1.Enabled = false;
            this.textBoxPrice1.Location = new System.Drawing.Point(165, 94);
            this.textBoxPrice1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrice1.Name = "textBoxPrice1";
            this.textBoxPrice1.Size = new System.Drawing.Size(55, 20);
            this.textBoxPrice1.TabIndex = 6;
            // 
            // textBoxVolume1
            // 
            this.textBoxVolume1.Enabled = false;
            this.textBoxVolume1.Location = new System.Drawing.Point(284, 95);
            this.textBoxVolume1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVolume1.Name = "textBoxVolume1";
            this.textBoxVolume1.Size = new System.Drawing.Size(67, 20);
            this.textBoxVolume1.TabIndex = 7;
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.Enabled = false;
            this.textBoxValue1.Location = new System.Drawing.Point(428, 95);
            this.textBoxValue1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.Size = new System.Drawing.Size(61, 20);
            this.textBoxValue1.TabIndex = 8;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Enabled = false;
            this.textBoxBalance.Location = new System.Drawing.Point(403, 20);
            this.textBoxBalance.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(85, 20);
            this.textBoxBalance.TabIndex = 9;
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.Location = new System.Drawing.Point(180, 331);
            this.radioButtonBuy.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(43, 17);
            this.radioButtonBuy.TabIndex = 10;
            this.radioButtonBuy.TabStop = true;
            this.radioButtonBuy.Text = "Buy";
            this.radioButtonBuy.UseVisualStyleBackColor = true;
            this.radioButtonBuy.CheckedChanged += new System.EventHandler(this.radioButtonBuy_CheckedChanged);
            // 
            // radioButtonSell
            // 
            this.radioButtonSell.AutoSize = true;
            this.radioButtonSell.Location = new System.Drawing.Point(180, 362);
            this.radioButtonSell.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSell.Name = "radioButtonSell";
            this.radioButtonSell.Size = new System.Drawing.Size(42, 17);
            this.radioButtonSell.TabIndex = 11;
            this.radioButtonSell.TabStop = true;
            this.radioButtonSell.Text = "Sell";
            this.radioButtonSell.UseVisualStyleBackColor = true;
            this.radioButtonSell.CheckedChanged += new System.EventHandler(this.radioButtonSell_CheckedChanged);
            // 
            // labelAmountBS
            // 
            this.labelAmountBS.AutoSize = true;
            this.labelAmountBS.Location = new System.Drawing.Point(236, 306);
            this.labelAmountBS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmountBS.Name = "labelAmountBS";
            this.labelAmountBS.Size = new System.Drawing.Size(43, 13);
            this.labelAmountBS.TabIndex = 12;
            this.labelAmountBS.Text = "Amount";
            // 
            // labelValueBS
            // 
            this.labelValueBS.AutoSize = true;
            this.labelValueBS.Location = new System.Drawing.Point(317, 306);
            this.labelValueBS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValueBS.Name = "labelValueBS";
            this.labelValueBS.Size = new System.Drawing.Size(34, 13);
            this.labelValueBS.TabIndex = 13;
            this.labelValueBS.Text = "Value";
            // 
            // buttonBuySell
            // 
            this.buttonBuySell.Location = new System.Drawing.Point(422, 340);
            this.buttonBuySell.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuySell.Name = "buttonBuySell";
            this.buttonBuySell.Size = new System.Drawing.Size(67, 26);
            this.buttonBuySell.TabIndex = 14;
            this.buttonBuySell.Text = "Buy/Sell";
            this.buttonBuySell.UseVisualStyleBackColor = true;
            this.buttonBuySell.Click += new System.EventHandler(this.buttonBuySell_Click);
            // 
            // labelTicker2
            // 
            this.labelTicker2.AutoSize = true;
            this.labelTicker2.Location = new System.Drawing.Point(77, 147);
            this.labelTicker2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTicker2.Name = "labelTicker2";
            this.labelTicker2.Size = new System.Drawing.Size(43, 13);
            this.labelTicker2.TabIndex = 15;
            this.labelTicker2.Text = "Ticker2";
            // 
            // labelTicker3
            // 
            this.labelTicker3.AutoSize = true;
            this.labelTicker3.Location = new System.Drawing.Point(77, 197);
            this.labelTicker3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTicker3.Name = "labelTicker3";
            this.labelTicker3.Size = new System.Drawing.Size(43, 13);
            this.labelTicker3.TabIndex = 16;
            this.labelTicker3.Text = "Ticker3";
            // 
            // textBoxPrice2
            // 
            this.textBoxPrice2.Enabled = false;
            this.textBoxPrice2.Location = new System.Drawing.Point(166, 140);
            this.textBoxPrice2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrice2.Name = "textBoxPrice2";
            this.textBoxPrice2.Size = new System.Drawing.Size(55, 20);
            this.textBoxPrice2.TabIndex = 17;
            // 
            // textBoxPrice3
            // 
            this.textBoxPrice3.Enabled = false;
            this.textBoxPrice3.Location = new System.Drawing.Point(166, 190);
            this.textBoxPrice3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrice3.Name = "textBoxPrice3";
            this.textBoxPrice3.Size = new System.Drawing.Size(54, 20);
            this.textBoxPrice3.TabIndex = 18;
            // 
            // textBoxVolume2
            // 
            this.textBoxVolume2.Enabled = false;
            this.textBoxVolume2.Location = new System.Drawing.Point(287, 144);
            this.textBoxVolume2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVolume2.Name = "textBoxVolume2";
            this.textBoxVolume2.Size = new System.Drawing.Size(64, 20);
            this.textBoxVolume2.TabIndex = 19;
            // 
            // textBoxVolume3
            // 
            this.textBoxVolume3.Enabled = false;
            this.textBoxVolume3.Location = new System.Drawing.Point(287, 194);
            this.textBoxVolume3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVolume3.Name = "textBoxVolume3";
            this.textBoxVolume3.Size = new System.Drawing.Size(64, 20);
            this.textBoxVolume3.TabIndex = 20;
            // 
            // textBoxValue2
            // 
            this.textBoxValue2.Enabled = false;
            this.textBoxValue2.Location = new System.Drawing.Point(428, 143);
            this.textBoxValue2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(59, 20);
            this.textBoxValue2.TabIndex = 21;
            // 
            // textBoxValue3
            // 
            this.textBoxValue3.Enabled = false;
            this.textBoxValue3.Location = new System.Drawing.Point(422, 194);
            this.textBoxValue3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValue3.Name = "textBoxValue3";
            this.textBoxValue3.Size = new System.Drawing.Size(61, 20);
            this.textBoxValue3.TabIndex = 22;
            // 
            // textBoxAmountBS
            // 
            this.textBoxAmountBS.Location = new System.Drawing.Point(234, 340);
            this.textBoxAmountBS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAmountBS.Name = "textBoxAmountBS";
            this.textBoxAmountBS.Size = new System.Drawing.Size(47, 20);
            this.textBoxAmountBS.TabIndex = 23;
            // 
            // textBoxValueBS
            // 
            this.textBoxValueBS.Enabled = false;
            this.textBoxValueBS.Location = new System.Drawing.Point(320, 340);
            this.textBoxValueBS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValueBS.Name = "textBoxValueBS";
            this.textBoxValueBS.Size = new System.Drawing.Size(47, 20);
            this.textBoxValueBS.TabIndex = 24;
            // 
            // timerExchange
            // 
            this.timerExchange.Enabled = true;
            this.timerExchange.Interval = 1000;
            this.timerExchange.Tick += new System.EventHandler(this.timerExchange_Tick);
            // 
            // listBoxExchange
            // 
            this.listBoxExchange.FormattingEnabled = true;
            this.listBoxExchange.Items.AddRange(new object[] {
            "Ticker1",
            "Ticker2",
            "Ticker3"});
            this.listBoxExchange.Location = new System.Drawing.Point(55, 331);
            this.listBoxExchange.Name = "listBoxExchange";
            this.listBoxExchange.Size = new System.Drawing.Size(94, 43);
            this.listBoxExchange.TabIndex = 25;
            // 
            // labelRovn
            // 
            this.labelRovn.AutoSize = true;
            this.labelRovn.Location = new System.Drawing.Point(295, 343);
            this.labelRovn.Name = "labelRovn";
            this.labelRovn.Size = new System.Drawing.Size(13, 13);
            this.labelRovn.TabIndex = 26;
            this.labelRovn.Text = "=";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Enabled = false;
            this.textBoxSum.Location = new System.Drawing.Point(412, 246);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(77, 20);
            this.textBoxSum.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "_________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonDetails1
            // 
            this.buttonDetails1.Location = new System.Drawing.Point(512, 92);
            this.buttonDetails1.Name = "buttonDetails1";
            this.buttonDetails1.Size = new System.Drawing.Size(55, 23);
            this.buttonDetails1.TabIndex = 29;
            this.buttonDetails1.Text = "Details";
            this.buttonDetails1.UseVisualStyleBackColor = true;
            this.buttonDetails1.Click += new System.EventHandler(this.buttonDetails1_Click);
            // 
            // buttonDetails2
            // 
            this.buttonDetails2.Location = new System.Drawing.Point(512, 141);
            this.buttonDetails2.Name = "buttonDetails2";
            this.buttonDetails2.Size = new System.Drawing.Size(55, 23);
            this.buttonDetails2.TabIndex = 30;
            this.buttonDetails2.Text = "Details";
            this.buttonDetails2.UseVisualStyleBackColor = true;
            this.buttonDetails2.Click += new System.EventHandler(this.buttonDetails2_Click);
            // 
            // buttonDetails3
            // 
            this.buttonDetails3.Location = new System.Drawing.Point(512, 192);
            this.buttonDetails3.Name = "buttonDetails3";
            this.buttonDetails3.Size = new System.Drawing.Size(55, 23);
            this.buttonDetails3.TabIndex = 31;
            this.buttonDetails3.Text = "Details";
            this.buttonDetails3.UseVisualStyleBackColor = true;
            this.buttonDetails3.Click += new System.EventHandler(this.buttonDetails3_Click);
            // 
            // Exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 398);
            this.Controls.Add(this.buttonDetails3);
            this.Controls.Add(this.buttonDetails2);
            this.Controls.Add(this.buttonDetails1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.labelRovn);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label labelRovn;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDetails1;
        private System.Windows.Forms.Button buttonDetails2;
        private System.Windows.Forms.Button buttonDetails3;
    }
}