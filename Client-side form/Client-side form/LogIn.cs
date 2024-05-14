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
            string logName = Convert.ToString(textBoxLogName);  
            string logPassword = Convert.ToString(textBoxLogName);
            string filePath = "C:\\Users\\jirif\\csharp\\osoby\\" + Name + ".csv";
            if (logName == )
            {

            }
            Form Exchange = new Exchange();
            Exchange.Show();
            this.Hide();
        }
    }
}
