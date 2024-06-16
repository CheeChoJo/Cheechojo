namespace Client_side_form
{
    partial class Details3
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
            this.listBoxRange = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRange
            // 
            this.listBoxRange.BackColor = System.Drawing.Color.HotPink;
            this.listBoxRange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxRange.Font = new System.Drawing.Font("Bradley Hand ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRange.FormattingEnabled = true;
            this.listBoxRange.ItemHeight = 35;
            this.listBoxRange.Items.AddRange(new object[] {
            "1 day",
            "1 week",
            "1 month",
            "1 year",
            "5 years",
            "max"});
            this.listBoxRange.Location = new System.Drawing.Point(180, 615);
            this.listBoxRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxRange.MultiColumn = true;
            this.listBoxRange.Name = "listBoxRange";
            this.listBoxRange.Size = new System.Drawing.Size(1000, 35);
            this.listBoxRange.TabIndex = 0;
            this.listBoxRange.SelectedIndexChanged += new System.EventHandler(this.listBoxRange_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Details for:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bradley Hand ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blackjack bot";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.DeepPink;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Bradley Hand ITC", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(22, 23);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(265, 77);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "<- Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // Details3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1200, 762);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxRange);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Details3";
            this.Text = "Details3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.ListBox listBoxRange;
    }
}