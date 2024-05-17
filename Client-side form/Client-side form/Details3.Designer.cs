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
            this.listBoxRange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxRange.FormattingEnabled = true;
            this.listBoxRange.Items.AddRange(new object[] {
            "1 day",
            "1 week",
            "1 month",
            "1 year",
            "5 years",
            "max"});
            this.listBoxRange.Location = new System.Drawing.Point(120, 400);
            this.listBoxRange.MultiColumn = true;
            this.listBoxRange.Name = "listBoxRange";
            this.listBoxRange.Size = new System.Drawing.Size(668, 17);
            this.listBoxRange.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Details for:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = " ticker3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(15, 15);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 50);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "<- Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // Details3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxRange);
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