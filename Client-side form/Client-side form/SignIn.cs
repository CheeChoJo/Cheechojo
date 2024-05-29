﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_side_form
{
    public partial class SignIn : Form
    {
        public _Account account = new _Account();
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignIn2_Click(object sender, EventArgs e)
        {
            string signName = Convert.ToString(textBoxSignName.Text);
            string signPassword = Convert.ToString(textBoxSignPass1.Text);
            string signRepeat = Convert.ToString(textBoxSignPass2.Text);
            string filePath = "C:\\Users\\Public\\Documents\\" + signName + ".txt";
            if (File.Exists(filePath)) 
            {
                MessageBox.Show("Such user already exists, please choose a different username.");
            }
            else
            {
                if (signPassword == signRepeat)
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {

                        writer.Write(signPassword);
                        Exchange Exchange = new Exchange();
                        Exchange.account = account;
                        Exchange.Show();
                        this.Hide();
                    }
                }
                else 
                {
                    MessageBox.Show("Passwords must match");
                }
            }
        }
    }
}
