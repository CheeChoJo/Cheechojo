using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_side_form
{
    public partial class CheeChoJoClient : Form
    {
        public CheeChoJoClient()
        {
            InitializeComponent();
        }

        private void CheeChoJoClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            Form LogIn = new LogIn();
            LogIn.Show();
            this.Hide();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Form SignIn = new SignIn();
            SignIn.Show();
            this.Hide();
        }
    }
}
