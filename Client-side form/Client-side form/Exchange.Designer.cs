﻿namespace Client_side_form
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(224, 9);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(56, 25);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.Location = new System.Drawing.Point(546, 9);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(64, 25);
            this.labelValue.TabIndex = 2;
            this.labelValue.Text = "Value";
            this.labelValue.Click += new System.EventHandler(this.labelValue_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.Location = new System.Drawing.Point(377, 9);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(80, 25);
            this.labelVolume.TabIndex = 3;
            this.labelVolume.Text = "Volume";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(12, 18);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(85, 25);
            this.labelBalance.TabIndex = 4;
            this.labelBalance.Text = "Balance";
            // 
            // labelTicker1
            // 
            this.labelTicker1.AutoSize = true;
            this.labelTicker1.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker1.Location = new System.Drawing.Point(94, 46);
            this.labelTicker1.Name = "labelTicker1";
            this.labelTicker1.Size = new System.Drawing.Size(58, 25);
            this.labelTicker1.TabIndex = 5;
            this.labelTicker1.Text = "BKR";
            // 
            // textBoxPrice1
            // 
            this.textBoxPrice1.BackColor = System.Drawing.Color.Pink;
            this.textBoxPrice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrice1.Enabled = false;
            this.textBoxPrice1.Font = new System.Drawing.Font("Bradley Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice1.Location = new System.Drawing.Point(220, 49);
            this.textBoxPrice1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrice1.Name = "textBoxPrice1";
            this.textBoxPrice1.Size = new System.Drawing.Size(71, 28);
            this.textBoxPrice1.TabIndex = 6;
            // 
            // textBoxVolume1
            // 
            this.textBoxVolume1.BackColor = System.Drawing.Color.Pink;
            this.textBoxVolume1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVolume1.Enabled = false;
            this.textBoxVolume1.Font = new System.Drawing.Font("Bradley Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVolume1.Location = new System.Drawing.Point(373, 49);
            this.textBoxVolume1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVolume1.Name = "textBoxVolume1";
            this.textBoxVolume1.Size = new System.Drawing.Size(87, 28);
            this.textBoxVolume1.TabIndex = 7;
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.BackColor = System.Drawing.Color.Pink;
            this.textBoxValue1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxValue1.Enabled = false;
            this.textBoxValue1.Font = new System.Drawing.Font("Bradley Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue1.Location = new System.Drawing.Point(539, 49);
            this.textBoxValue1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.Size = new System.Drawing.Size(80, 28);
            this.textBoxValue1.TabIndex = 8;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.BackColor = System.Drawing.Color.Pink;
            this.textBoxBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBalance.Enabled = false;
            this.textBoxBalance.Location = new System.Drawing.Point(105, 18);
            this.textBoxBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(112, 22);
            this.textBoxBalance.TabIndex = 9;
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBuy.Location = new System.Drawing.Point(188, 42);
            this.radioButtonBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(73, 29);
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
            this.radioButtonSell.Location = new System.Drawing.Point(188, 68);
            this.radioButtonSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSell.Name = "radioButtonSell";
            this.radioButtonSell.Size = new System.Drawing.Size(70, 29);
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
            this.labelAmountBS.Location = new System.Drawing.Point(290, 45);
            this.labelAmountBS.Name = "labelAmountBS";
            this.labelAmountBS.Size = new System.Drawing.Size(87, 25);
            this.labelAmountBS.TabIndex = 12;
            this.labelAmountBS.Text = "Amount";
            // 
            // labelValueBS
            // 
            this.labelValueBS.AutoSize = true;
            this.labelValueBS.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueBS.Location = new System.Drawing.Point(556, 45);
            this.labelValueBS.Name = "labelValueBS";
            this.labelValueBS.Size = new System.Drawing.Size(64, 25);
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
            this.buttonBuySell.Location = new System.Drawing.Point(665, 30);
            this.buttonBuySell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuySell.Name = "buttonBuySell";
            this.buttonBuySell.Size = new System.Drawing.Size(124, 80);
            this.buttonBuySell.TabIndex = 14;
            this.buttonBuySell.Text = "Buy/Sell";
            this.buttonBuySell.UseVisualStyleBackColor = false;
            this.buttonBuySell.Click += new System.EventHandler(this.buttonBuySell_Click);
            // 
            // labelTicker2
            // 
            this.labelTicker2.AutoSize = true;
            this.labelTicker2.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker2.Location = new System.Drawing.Point(94, 103);
            this.labelTicker2.Name = "labelTicker2";
            this.labelTicker2.Size = new System.Drawing.Size(60, 25);
            this.labelTicker2.TabIndex = 15;
            this.labelTicker2.Text = "STW";
            // 
            // labelTicker3
            // 
            this.labelTicker3.AutoSize = true;
            this.labelTicker3.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker3.Location = new System.Drawing.Point(94, 161);
            this.labelTicker3.Name = "labelTicker3";
            this.labelTicker3.Size = new System.Drawing.Size(46, 25);
            this.labelTicker3.TabIndex = 16;
            this.labelTicker3.Text = "BJB";
            // 
            // textBoxPrice2
            // 
            this.textBoxPrice2.BackColor = System.Drawing.Color.Pink;
            this.textBoxPrice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrice2.Enabled = false;
            this.textBoxPrice2.Font = new System.Drawing.Font("Bradley Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice2.Location = new System.Drawing.Point(220, 108);
            this.textBoxPrice2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrice2.Name = "textBoxPrice2";
            this.textBoxPrice2.Size = new System.Drawing.Size(71, 28);
            this.textBoxPrice2.TabIndex = 17;
            // 
            // textBoxPrice3
            // 
            this.textBoxPrice3.BackColor = System.Drawing.Color.Pink;
            this.textBoxPrice3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrice3.Enabled = false;
            this.textBoxPrice3.Font = new System.Drawing.Font("Bradley Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice3.Location = new System.Drawing.Point(220, 166);
            this.textBoxPrice3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrice3.Name = "textBoxPrice3";
            this.textBoxPrice3.Size = new System.Drawing.Size(71, 28);
            this.textBoxPrice3.TabIndex = 18;
            this.textBoxPrice3.TextChanged += new System.EventHandler(this.textBoxPrice3_TextChanged);
            // 
            // textBoxVolume2
            // 
            this.textBoxVolume2.BackColor = System.Drawing.Color.Pink;
            this.textBoxVolume2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVolume2.Enabled = false;
            this.textBoxVolume2.Font = new System.Drawing.Font("Bradley Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVolume2.Location = new System.Drawing.Point(373, 108);
            this.textBoxVolume2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVolume2.Name = "textBoxVolume2";
            this.textBoxVolume2.Size = new System.Drawing.Size(87, 28);
            this.textBoxVolume2.TabIndex = 19;
            // 
            // textBoxVolume3
            // 
            this.textBoxVolume3.BackColor = System.Drawing.Color.Pink;
            this.textBoxVolume3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVolume3.Enabled = false;
            this.textBoxVolume3.Font = new System.Drawing.Font("Bradley Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVolume3.Location = new System.Drawing.Point(373, 166);
            this.textBoxVolume3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVolume3.Name = "textBoxVolume3";
            this.textBoxVolume3.Size = new System.Drawing.Size(87, 28);
            this.textBoxVolume3.TabIndex = 20;
            // 
            // textBoxValue2
            // 
            this.textBoxValue2.BackColor = System.Drawing.Color.Pink;
            this.textBoxValue2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxValue2.Enabled = false;
            this.textBoxValue2.Font = new System.Drawing.Font("Bradley Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue2.Location = new System.Drawing.Point(539, 108);
            this.textBoxValue2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(80, 28);
            this.textBoxValue2.TabIndex = 21;
            // 
            // textBoxValue3
            // 
            this.textBoxValue3.BackColor = System.Drawing.Color.Pink;
            this.textBoxValue3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxValue3.Enabled = false;
            this.textBoxValue3.Font = new System.Drawing.Font("Bradley Hand ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue3.Location = new System.Drawing.Point(539, 166);
            this.textBoxValue3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxValue3.Name = "textBoxValue3";
            this.textBoxValue3.Size = new System.Drawing.Size(80, 28);
            this.textBoxValue3.TabIndex = 22;
            // 
            // textBoxAmountBS
            // 
            this.textBoxAmountBS.Location = new System.Drawing.Point(286, 71);
            this.textBoxAmountBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAmountBS.Name = "textBoxAmountBS";
            this.textBoxAmountBS.Size = new System.Drawing.Size(87, 22);
            this.textBoxAmountBS.TabIndex = 23;
            // 
            // textBoxValueBS
            // 
            this.textBoxValueBS.Enabled = false;
            this.textBoxValueBS.Location = new System.Drawing.Point(551, 73);
            this.textBoxValueBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxValueBS.Name = "textBoxValueBS";
            this.textBoxValueBS.Size = new System.Drawing.Size(83, 22);
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
            this.listBoxExchange.BackColor = System.Drawing.Color.Pink;
            this.listBoxExchange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxExchange.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExchange.FormattingEnabled = true;
            this.listBoxExchange.ItemHeight = 25;
            this.listBoxExchange.Items.AddRange(new object[] {
            "BKR",
            "STW",
            "BJB"});
            this.listBoxExchange.Location = new System.Drawing.Point(24, 26);
            this.listBoxExchange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxExchange.Name = "listBoxExchange";
            this.listBoxExchange.Size = new System.Drawing.Size(124, 50);
            this.listBoxExchange.TabIndex = 25;
            // 
            // labelRovn
            // 
            this.labelRovn.AutoSize = true;
            this.labelRovn.BackColor = System.Drawing.Color.Transparent;
            this.labelRovn.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRovn.Location = new System.Drawing.Point(379, 66);
            this.labelRovn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRovn.Name = "labelRovn";
            this.labelRovn.Size = new System.Drawing.Size(29, 27);
            this.labelRovn.TabIndex = 26;
            this.labelRovn.Text = "→";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Enabled = false;
            this.textBoxSum.Location = new System.Drawing.Point(815, 237);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(102, 22);
            this.textBoxSum.TabIndex = 27;
            // 
            // buttonDetails1
            // 
            this.buttonDetails1.BackColor = System.Drawing.Color.Pink;
            this.buttonDetails1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetails1.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetails1.Location = new System.Drawing.Point(665, 42);
            this.buttonDetails1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDetails1.Name = "buttonDetails1";
            this.buttonDetails1.Size = new System.Drawing.Size(99, 34);
            this.buttonDetails1.TabIndex = 29;
            this.buttonDetails1.Text = "Details";
            this.buttonDetails1.UseVisualStyleBackColor = false;
            this.buttonDetails1.Click += new System.EventHandler(this.buttonDetails1_Click);
            // 
            // buttonDetails2
            // 
            this.buttonDetails2.BackColor = System.Drawing.Color.Pink;
            this.buttonDetails2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetails2.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetails2.Location = new System.Drawing.Point(665, 99);
            this.buttonDetails2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDetails2.Name = "buttonDetails2";
            this.buttonDetails2.Size = new System.Drawing.Size(99, 34);
            this.buttonDetails2.TabIndex = 30;
            this.buttonDetails2.Text = "Details";
            this.buttonDetails2.UseVisualStyleBackColor = false;
            this.buttonDetails2.Click += new System.EventHandler(this.buttonDetails2_Click);
            // 
            // buttonDetails3
            // 
            this.buttonDetails3.BackColor = System.Drawing.Color.Pink;
            this.buttonDetails3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetails3.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetails3.Location = new System.Drawing.Point(665, 157);
            this.buttonDetails3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDetails3.Name = "buttonDetails3";
            this.buttonDetails3.Size = new System.Drawing.Size(99, 34);
            this.buttonDetails3.TabIndex = 31;
            this.buttonDetails3.Text = "Details";
            this.buttonDetails3.UseVisualStyleBackColor = false;
            this.buttonDetails3.Click += new System.EventHandler(this.buttonDetails3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepPink;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelRovn);
            this.panel1.Controls.Add(this.listBoxExchange);
            this.panel1.Controls.Add(this.textBoxValueBS);
            this.panel1.Controls.Add(this.textBoxAmountBS);
            this.panel1.Controls.Add(this.buttonBuySell);
            this.panel1.Controls.Add(this.labelValueBS);
            this.panel1.Controls.Add(this.labelAmountBS);
            this.panel1.Controls.Add(this.radioButtonSell);
            this.panel1.Controls.Add(this.radioButtonBuy);
            this.panel1.Location = new System.Drawing.Point(12, 382);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 138);
            this.panel1.TabIndex = 32;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(417, 30);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(804, 30);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "→";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepPink;
            this.panel2.Controls.Add(this.textBoxUser);
            this.panel2.Controls.Add(this.labelUser);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBoxBalance);
            this.panel2.Controls.Add(this.labelBalance);
            this.panel2.Location = new System.Drawing.Point(631, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 97);
            this.panel2.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 93);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            this.panel3.Location = new System.Drawing.Point(12, 112);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(920, 262);
            this.panel3.TabIndex = 34;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(12, 54);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(53, 25);
            this.labelUser.TabIndex = 11;
            this.labelUser.Text = "User";
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.Pink;
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUser.Enabled = false;
            this.textBoxUser.Location = new System.Drawing.Point(104, 56);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(112, 22);
            this.textBoxUser.TabIndex = 12;
            // 
            // Exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(940, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Exchange";
            this.Text = "Exchange";
            this.Load += new System.EventHandler(this.Exchange_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
    }
}