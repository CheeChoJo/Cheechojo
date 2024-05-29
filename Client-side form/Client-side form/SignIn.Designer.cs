namespace Client_side_form
{
    partial class SignIn
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
            this.textBoxSignName = new System.Windows.Forms.TextBox();
            this.textBoxSignPass1 = new System.Windows.Forms.TextBox();
            this.textBoxSignPass2 = new System.Windows.Forms.TextBox();
            this.buttonSignIn2 = new System.Windows.Forms.Button();
            this.labelSignName = new System.Windows.Forms.Label();
            this.labelSignPass1 = new System.Windows.Forms.Label();
            this.labelSignPass2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSignName
            // 
            this.textBoxSignName.Location = new System.Drawing.Point(193, 32);
            this.textBoxSignName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSignName.Name = "textBoxSignName";
            this.textBoxSignName.Size = new System.Drawing.Size(139, 20);
            this.textBoxSignName.TabIndex = 0;
            // 
            // textBoxSignPass1
            // 
            this.textBoxSignPass1.Location = new System.Drawing.Point(194, 86);
            this.textBoxSignPass1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSignPass1.Name = "textBoxSignPass1";
            this.textBoxSignPass1.Size = new System.Drawing.Size(137, 20);
            this.textBoxSignPass1.TabIndex = 1;
            // 
            // textBoxSignPass2
            // 
            this.textBoxSignPass2.Location = new System.Drawing.Point(197, 138);
            this.textBoxSignPass2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSignPass2.Name = "textBoxSignPass2";
            this.textBoxSignPass2.Size = new System.Drawing.Size(134, 20);
            this.textBoxSignPass2.TabIndex = 2;
            // 
            // buttonSignIn2
            // 
            this.buttonSignIn2.Location = new System.Drawing.Point(203, 188);
            this.buttonSignIn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSignIn2.Name = "buttonSignIn2";
            this.buttonSignIn2.Size = new System.Drawing.Size(120, 25);
            this.buttonSignIn2.TabIndex = 3;
            this.buttonSignIn2.Text = "Sign Up";
            this.buttonSignIn2.UseVisualStyleBackColor = true;
            this.buttonSignIn2.Click += new System.EventHandler(this.buttonSignIn2_Click);
            // 
            // labelSignName
            // 
            this.labelSignName.AutoSize = true;
            this.labelSignName.Location = new System.Drawing.Point(61, 34);
            this.labelSignName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSignName.Name = "labelSignName";
            this.labelSignName.Size = new System.Drawing.Size(55, 13);
            this.labelSignName.TabIndex = 4;
            this.labelSignName.Text = "Username";
            // 
            // labelSignPass1
            // 
            this.labelSignPass1.AutoSize = true;
            this.labelSignPass1.Location = new System.Drawing.Point(61, 92);
            this.labelSignPass1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSignPass1.Name = "labelSignPass1";
            this.labelSignPass1.Size = new System.Drawing.Size(53, 13);
            this.labelSignPass1.TabIndex = 5;
            this.labelSignPass1.Text = "Password";
            // 
            // labelSignPass2
            // 
            this.labelSignPass2.AutoSize = true;
            this.labelSignPass2.Location = new System.Drawing.Point(51, 144);
            this.labelSignPass2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSignPass2.Name = "labelSignPass2";
            this.labelSignPass2.Size = new System.Drawing.Size(91, 13);
            this.labelSignPass2.TabIndex = 6;
            this.labelSignPass2.Text = "Repeat Password";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 398);
            this.Controls.Add(this.labelSignPass2);
            this.Controls.Add(this.labelSignPass1);
            this.Controls.Add(this.labelSignName);
            this.Controls.Add(this.buttonSignIn2);
            this.Controls.Add(this.textBoxSignPass2);
            this.Controls.Add(this.textBoxSignPass1);
            this.Controls.Add(this.textBoxSignName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSignName;
        private System.Windows.Forms.TextBox textBoxSignPass1;
        private System.Windows.Forms.TextBox textBoxSignPass2;
        private System.Windows.Forms.Button buttonSignIn2;
        private System.Windows.Forms.Label labelSignName;
        private System.Windows.Forms.Label labelSignPass1;
        private System.Windows.Forms.Label labelSignPass2;
    }
}