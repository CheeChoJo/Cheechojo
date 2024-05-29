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
        private _Account account;
        public CheeChoJoClient()
        {
            InitializeComponent();
            account = new _Account();
        }

        private void CheeChoJoClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            LogIn LogIn = new LogIn();
            LogIn.account = account;
            LogIn.Show();
            this.Hide();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignIn SignIn = new SignIn();
            SignIn.account = account;
            SignIn.Show();
            this.Hide();
        }
    }
}
