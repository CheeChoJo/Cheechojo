using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Client_side_form
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn2_Click(object sender, EventArgs e)
        {
            //uložit username a password
            //if username existuje? (najdeme txt file?)
            //      pokud ne - hodíme no user error
            //      pokud ano - if pass matchuje?
            //              pokud ne - hodíme nematchuje pass error
            //              pokud ano - otevřeme exchange.cs
            string logName = Convert.ToString(textBoxLogName.Text);
            string logPassword = Convert.ToString(textBoxLogPass.Text);
            string filePath = "C:\\Users\\Public\\Documents\\" + logName + ".txt";
            if (File.Exists(filePath) == false)
            {
                MessageBox.Show("No such user exists!");
            }
            else
            {
                string filePassword = File.ReadAllText(filePath);
                if (filePassword == logPassword)
                {
                    Form Exchange = new Exchange();
                    Exchange.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                }
            }
        }
    }
}
