namespace Client_side_form
{
    partial class LogIn
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
            this.textBoxLogName = new System.Windows.Forms.TextBox();
            this.textBoxLogPass = new System.Windows.Forms.TextBox();
            this.buttonLogIn2 = new System.Windows.Forms.Button();
            this.labelLogName = new System.Windows.Forms.Label();
            this.labelLogPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogName
            // 
            this.textBoxLogName.BackColor = System.Drawing.Color.HotPink;
            this.textBoxLogName.Location = new System.Drawing.Point(12, 197);
            this.textBoxLogName.Name = "textBoxLogName";
            this.textBoxLogName.Size = new System.Drawing.Size(221, 26);
            this.textBoxLogName.TabIndex = 0;
            // 
            // textBoxLogPass
            // 
            this.textBoxLogPass.BackColor = System.Drawing.Color.HotPink;
            this.textBoxLogPass.Location = new System.Drawing.Point(496, 303);
            this.textBoxLogPass.Name = "textBoxLogPass";
            this.textBoxLogPass.Size = new System.Drawing.Size(221, 26);
            this.textBoxLogPass.TabIndex = 1;
            // 
            // buttonLogIn2
            // 
            this.buttonLogIn2.BackColor = System.Drawing.Color.DeepPink;
            this.buttonLogIn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn2.Font = new System.Drawing.Font("Bradley Hand ITC", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn2.Location = new System.Drawing.Point(237, 404);
            this.buttonLogIn2.Name = "buttonLogIn2";
            this.buttonLogIn2.Size = new System.Drawing.Size(259, 80);
            this.buttonLogIn2.TabIndex = 2;
            this.buttonLogIn2.Text = "Log In";
            this.buttonLogIn2.UseVisualStyleBackColor = false;
            this.buttonLogIn2.Click += new System.EventHandler(this.buttonLogIn2_Click);
            // 
            // labelLogName
            // 
            this.labelLogName.AutoSize = true;
            this.labelLogName.Font = new System.Drawing.Font("Bradley Hand ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogName.Location = new System.Drawing.Point(12, 159);
            this.labelLogName.Name = "labelLogName";
            this.labelLogName.Size = new System.Drawing.Size(140, 35);
            this.labelLogName.TabIndex = 3;
            this.labelLogName.Text = "Username";
            // 
            // labelLogPass
            // 
            this.labelLogPass.AutoSize = true;
            this.labelLogPass.Font = new System.Drawing.Font("Bradley Hand ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogPass.Location = new System.Drawing.Point(587, 265);
            this.labelLogPass.Name = "labelLogPass";
            this.labelLogPass.Size = new System.Drawing.Size(130, 35);
            this.labelLogPass.TabIndex = 4;
            this.labelLogPass.Text = "Password";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(729, 612);
            this.Controls.Add(this.labelLogPass);
            this.Controls.Add(this.labelLogName);
            this.Controls.Add(this.buttonLogIn2);
            this.Controls.Add(this.textBoxLogPass);
            this.Controls.Add(this.textBoxLogName);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogName;
        private System.Windows.Forms.TextBox textBoxLogPass;
        private System.Windows.Forms.Button buttonLogIn2;
        private System.Windows.Forms.Label labelLogName;
        private System.Windows.Forms.Label labelLogPass;
    }
}