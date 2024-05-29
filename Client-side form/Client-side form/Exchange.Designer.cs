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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exchange));
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
            this.buttonDetails1 = new System.Windows.Forms.Button();
            this.buttonDetails2 = new System.Windows.Forms.Button();
            this.buttonDetails3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(252, 11);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(66, 30);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.Location = new System.Drawing.Point(614, 11);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(75, 30);
            this.labelValue.TabIndex = 2;
            this.labelValue.Text = "Value";
            this.labelValue.Click += new System.EventHandler(this.labelValue_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.Location = new System.Drawing.Point(424, 11);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(95, 30);
            this.labelVolume.TabIndex = 3;
            this.labelVolume.Text = "Volume";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(3, 17);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(101, 30);
            this.labelBalance.TabIndex = 4;
            this.labelBalance.Text = "Balance";
            // 
            // labelTicker1
            // 
            this.labelTicker1.AutoSize = true;
            this.labelTicker1.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker1.Location = new System.Drawing.Point(106, 57);
            this.labelTicker1.Name = "labelTicker1";
            this.labelTicker1.Size = new System.Drawing.Size(68, 30);
            this.labelTicker1.TabIndex = 5;
            this.labelTicker1.Text = "BKR";
            // 
            // textBoxPrice1
            // 
            this.textBoxPrice1.Enabled = false;
            this.textBoxPrice1.Location = new System.Drawing.Point(247, 61);
            this.textBoxPrice1.Name = "textBoxPrice1";
            this.textBoxPrice1.Size = new System.Drawing.Size(80, 26);
            this.textBoxPrice1.TabIndex = 6;
            // 
            // textBoxVolume1
            // 
            this.textBoxVolume1.Enabled = false;
            this.textBoxVolume1.Location = new System.Drawing.Point(420, 61);
            this.textBoxVolume1.Name = "textBoxVolume1";
            this.textBoxVolume1.Size = new System.Drawing.Size(98, 26);
            this.textBoxVolume1.TabIndex = 7;
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.Enabled = false;
            this.textBoxValue1.Location = new System.Drawing.Point(606, 61);
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.Size = new System.Drawing.Size(90, 26);
            this.textBoxValue1.TabIndex = 8;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Enabled = false;
            this.textBoxBalance.Location = new System.Drawing.Point(99, 23);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(126, 26);
            this.textBoxBalance.TabIndex = 9;
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBuy.Location = new System.Drawing.Point(211, 52);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(86, 34);
            this.radioButtonBuy.TabIndex = 10;
            this.radioButtonBuy.TabStop = true;
            this.radioButtonBuy.Text = "Buy";
            this.radioButtonBuy.UseVisualStyleBackColor = true;
            this.radioButtonBuy.CheckedChanged += new System.EventHandler(this.radioButtonBuy_CheckedChanged);
            // 
            // radioButtonSell
            // 
            this.radioButtonSell.AutoSize = true;
            this.radioButtonSell.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSell.Location = new System.Drawing.Point(211, 85);
            this.radioButtonSell.Name = "radioButtonSell";
            this.radioButtonSell.Size = new System.Drawing.Size(82, 34);
            this.radioButtonSell.TabIndex = 11;
            this.radioButtonSell.TabStop = true;
            this.radioButtonSell.Text = "Sell";
            this.radioButtonSell.UseVisualStyleBackColor = true;
            this.radioButtonSell.CheckedChanged += new System.EventHandler(this.radioButtonSell_CheckedChanged);
            // 
            // labelAmountBS
            // 
            this.labelAmountBS.AutoSize = true;
            this.labelAmountBS.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountBS.Location = new System.Drawing.Point(326, 56);
            this.labelAmountBS.Name = "labelAmountBS";
            this.labelAmountBS.Size = new System.Drawing.Size(104, 30);
            this.labelAmountBS.TabIndex = 12;
            this.labelAmountBS.Text = "Amount";
            // 
            // labelValueBS
            // 
            this.labelValueBS.AutoSize = true;
            this.labelValueBS.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueBS.Location = new System.Drawing.Point(626, 56);
            this.labelValueBS.Name = "labelValueBS";
            this.labelValueBS.Size = new System.Drawing.Size(75, 30);
            this.labelValueBS.TabIndex = 13;
            this.labelValueBS.Text = "Value";
            // 
            // buttonBuySell
            // 
            this.buttonBuySell.BackColor = System.Drawing.Color.Pink;
            this.buttonBuySell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBuySell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuySell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuySell.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuySell.ForeColor = System.Drawing.Color.Black;
            this.buttonBuySell.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonBuySell.Location = new System.Drawing.Point(748, 37);
            this.buttonBuySell.Name = "buttonBuySell";
            this.buttonBuySell.Size = new System.Drawing.Size(139, 95);
            this.buttonBuySell.TabIndex = 14;
            this.buttonBuySell.Text = "Buy/Sell";
            this.buttonBuySell.UseVisualStyleBackColor = false;
            this.buttonBuySell.Click += new System.EventHandler(this.buttonBuySell_Click);
            // 
            // labelTicker2
            // 
            this.labelTicker2.AutoSize = true;
            this.labelTicker2.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker2.Location = new System.Drawing.Point(106, 129);
            this.labelTicker2.Name = "labelTicker2";
            this.labelTicker2.Size = new System.Drawing.Size(70, 30);
            this.labelTicker2.TabIndex = 15;
            this.labelTicker2.Text = "STW";
            // 
            // labelTicker3
            // 
            this.labelTicker3.AutoSize = true;
            this.labelTicker3.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker3.Location = new System.Drawing.Point(106, 201);
            this.labelTicker3.Name = "labelTicker3";
            this.labelTicker3.Size = new System.Drawing.Size(98, 30);
            this.labelTicker3.TabIndex = 16;
            this.labelTicker3.Text = "Ticker3";
            // 
            // textBoxPrice2
            // 
            this.textBoxPrice2.Enabled = false;
            this.textBoxPrice2.Location = new System.Drawing.Point(247, 135);
            this.textBoxPrice2.Name = "textBoxPrice2";
            this.textBoxPrice2.Size = new System.Drawing.Size(80, 26);
            this.textBoxPrice2.TabIndex = 17;
            // 
            // textBoxPrice3
            // 
            this.textBoxPrice3.Enabled = false;
            this.textBoxPrice3.Location = new System.Drawing.Point(247, 207);
            this.textBoxPrice3.Name = "textBoxPrice3";
            this.textBoxPrice3.Size = new System.Drawing.Size(80, 26);
            this.textBoxPrice3.TabIndex = 18;
            this.textBoxPrice3.TextChanged += new System.EventHandler(this.textBoxPrice3_TextChanged);
            // 
            // textBoxVolume2
            // 
            this.textBoxVolume2.Enabled = false;
            this.textBoxVolume2.Location = new System.Drawing.Point(420, 135);
            this.textBoxVolume2.Name = "textBoxVolume2";
            this.textBoxVolume2.Size = new System.Drawing.Size(98, 26);
            this.textBoxVolume2.TabIndex = 19;
            // 
            // textBoxVolume3
            // 
            this.textBoxVolume3.Enabled = false;
            this.textBoxVolume3.Location = new System.Drawing.Point(420, 207);
            this.textBoxVolume3.Name = "textBoxVolume3";
            this.textBoxVolume3.Size = new System.Drawing.Size(98, 26);
            this.textBoxVolume3.TabIndex = 20;
            // 
            // textBoxValue2
            // 
            this.textBoxValue2.Enabled = false;
            this.textBoxValue2.Location = new System.Drawing.Point(606, 135);
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(90, 26);
            this.textBoxValue2.TabIndex = 21;
            // 
            // textBoxValue3
            // 
            this.textBoxValue3.Enabled = false;
            this.textBoxValue3.Location = new System.Drawing.Point(606, 207);
            this.textBoxValue3.Name = "textBoxValue3";
            this.textBoxValue3.Size = new System.Drawing.Size(90, 26);
            this.textBoxValue3.TabIndex = 22;
            // 
            // textBoxAmountBS
            // 
            this.textBoxAmountBS.Location = new System.Drawing.Point(322, 89);
            this.textBoxAmountBS.Name = "textBoxAmountBS";
            this.textBoxAmountBS.Size = new System.Drawing.Size(97, 26);
            this.textBoxAmountBS.TabIndex = 23;
            // 
            // textBoxValueBS
            // 
            this.textBoxValueBS.Enabled = false;
            this.textBoxValueBS.Location = new System.Drawing.Point(620, 91);
            this.textBoxValueBS.Name = "textBoxValueBS";
            this.textBoxValueBS.Size = new System.Drawing.Size(93, 26);
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
            this.listBoxExchange.BackColor = System.Drawing.Color.LightGray;
            this.listBoxExchange.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExchange.FormattingEnabled = true;
            this.listBoxExchange.ItemHeight = 30;
            this.listBoxExchange.Items.AddRange(new object[] {
            "Ticker1",
            "Ticker2",
            "Ticker3"});
            this.listBoxExchange.Location = new System.Drawing.Point(27, 32);
            this.listBoxExchange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxExchange.Name = "listBoxExchange";
            this.listBoxExchange.Size = new System.Drawing.Size(139, 94);
            this.listBoxExchange.TabIndex = 25;
            // 
            // labelRovn
            // 
            this.labelRovn.AutoSize = true;
            this.labelRovn.BackColor = System.Drawing.Color.Transparent;
            this.labelRovn.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRovn.Location = new System.Drawing.Point(426, 83);
            this.labelRovn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRovn.Name = "labelRovn";
            this.labelRovn.Size = new System.Drawing.Size(36, 32);
            this.labelRovn.TabIndex = 26;
            this.labelRovn.Text = "→";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Enabled = false;
            this.textBoxSum.Location = new System.Drawing.Point(917, 296);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(114, 26);
            this.textBoxSum.TabIndex = 27;
            // 
            // buttonDetails1
            // 
            this.buttonDetails1.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetails1.Location = new System.Drawing.Point(748, 52);
            this.buttonDetails1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDetails1.Name = "buttonDetails1";
            this.buttonDetails1.Size = new System.Drawing.Size(111, 42);
            this.buttonDetails1.TabIndex = 29;
            this.buttonDetails1.Text = "Details";
            this.buttonDetails1.UseVisualStyleBackColor = true;
            this.buttonDetails1.Click += new System.EventHandler(this.buttonDetails1_Click);
            // 
            // buttonDetails2
            // 
            this.buttonDetails2.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetails2.Location = new System.Drawing.Point(748, 124);
            this.buttonDetails2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDetails2.Name = "buttonDetails2";
            this.buttonDetails2.Size = new System.Drawing.Size(111, 42);
            this.buttonDetails2.TabIndex = 30;
            this.buttonDetails2.Text = "Details";
            this.buttonDetails2.UseVisualStyleBackColor = true;
            this.buttonDetails2.Click += new System.EventHandler(this.buttonDetails2_Click);
            // 
            // buttonDetails3
            // 
            this.buttonDetails3.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetails3.Location = new System.Drawing.Point(748, 196);
            this.buttonDetails3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDetails3.Name = "buttonDetails3";
            this.buttonDetails3.Size = new System.Drawing.Size(111, 43);
            this.buttonDetails3.TabIndex = 31;
            this.buttonDetails3.Text = "Details";
            this.buttonDetails3.UseVisualStyleBackColor = true;
            this.buttonDetails3.Click += new System.EventHandler(this.buttonDetails3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepPink;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelRovn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBoxExchange);
            this.panel1.Controls.Add(this.textBoxValueBS);
            this.panel1.Controls.Add(this.textBoxAmountBS);
            this.panel1.Controls.Add(this.buttonBuySell);
            this.panel1.Controls.Add(this.labelValueBS);
            this.panel1.Controls.Add(this.labelAmountBS);
            this.panel1.Controls.Add(this.radioButtonSell);
            this.panel1.Controls.Add(this.radioButtonBuy);
            this.panel1.Location = new System.Drawing.Point(10, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 172);
            this.panel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "→";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(467, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 100);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(893, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 95);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepPink;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.textBoxBalance);
            this.panel2.Controls.Add(this.labelBalance);
            this.panel2.Location = new System.Drawing.Point(721, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 72);
            this.panel2.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(239, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 66);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.HotPink;
            this.panel3.Controls.Add(this.buttonDetails3);
            this.panel3.Controls.Add(this.buttonDetails2);
            this.panel3.Controls.Add(this.buttonDetails1);
            this.panel3.Controls.Add(this.textBoxSum);
            this.panel3.Controls.Add(this.textBoxValue3);
            this.panel3.Controls.Add(this.textBoxValue2);
            this.panel3.Controls.Add(this.textBoxVolume3);
            this.panel3.Controls.Add(this.textBoxVolume2);
            this.panel3.Controls.Add(this.textBoxPrice3);
            this.panel3.Controls.Add(this.textBoxPrice2);
            this.panel3.Controls.Add(this.labelTicker3);
            this.panel3.Controls.Add(this.labelTicker2);
            this.panel3.Controls.Add(this.textBoxValue1);
            this.panel3.Controls.Add(this.textBoxVolume1);
            this.panel3.Controls.Add(this.textBoxPrice1);
            this.panel3.Controls.Add(this.labelTicker1);
            this.panel3.Controls.Add(this.labelVolume);
            this.panel3.Controls.Add(this.labelValue);
            this.panel3.Controls.Add(this.labelPrice);
            this.panel3.Location = new System.Drawing.Point(10, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1035, 327);
            this.panel3.TabIndex = 34;
            // 
            // Exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1057, 612);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Exchange";
            this.Text = "Exchange";
            this.Load += new System.EventHandler(this.Exchange_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button buttonDetails1;
        private System.Windows.Forms.Button buttonDetails2;
        private System.Windows.Forms.Button buttonDetails3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
    }
}