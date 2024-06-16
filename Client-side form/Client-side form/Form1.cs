using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_side_form
{
    public partial class CheeChoJoClient : Form
    {
        private _Account account;
        public string serverUrl;
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
            serverUrl = Convert.ToString(textBoxUrl.Text);
            LogIn logIn = new LogIn(this);
            logIn.account = account;
            logIn.serverUrl = serverUrl;
            logIn.Show();
            this.Hide();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            serverUrl = Convert.ToString(textBoxUrl.Text);
            SignIn signIn = new SignIn(this);
            signIn.account = account;
            signIn.serverUrl = serverUrl;
            signIn.Show();
            this.Hide();
        }
    }
}
