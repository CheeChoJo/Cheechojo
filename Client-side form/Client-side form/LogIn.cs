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
using Newtonsoft.Json;
using System.Net.Http;

namespace Client_side_form
{
    public partial class LogIn : Form
    {
        public _Account account { get; set; }
        private CheeChoJoClient previousForm;
        public LogIn(CheeChoJoClient form)
        {
            InitializeComponent();
            previousForm = form;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        public async void buttonLogIn2_Click(object sender, EventArgs e)
        {
            //uložit username a password
            //if username existuje? (najdeme txt file?)
            //      pokud ne - hodíme no user error
            //      pokud ano - if pass matchuje?
            //              pokud ne - hodíme nematchuje pass error
            //              pokud ano - otevřeme exchange.cs
            ///////////////
            string logName = Convert.ToString(textBoxLogName.Text);
            string logPassword = Convert.ToString(textBoxLogPass.Text);
            using (var client = new HttpClient())
            {
                var url = "http://194.108.31.75:7142/login";
                var dataToSend = new
                {
                    userName = account.userName,
                    password = logPassword,
                };
                var json = JsonConvert.SerializeObject(dataToSend);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                try
                {
                    response = await client.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        account = JsonConvert.DeserializeObject<_Account>(responseContent);
                        MessageBox.Show(Convert.ToString(account.balance));
                        Exchange Exchange = new Exchange();
                        Exchange.account = account;
                        Exchange.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("PEBCAK Error!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Došlo k chybě: {ex.Message}");
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}
