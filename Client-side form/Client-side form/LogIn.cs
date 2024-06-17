using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Client_side_form
{
    public partial class LogIn : Form
    {
        public _Account account { get; set; }
        private CheeChoJoClient previousForm;
        public string serverUrl { get; set; }

        public LogIn(CheeChoJoClient form)
        {
            InitializeComponent();
            previousForm = form;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            // Load event logic, if necessary
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
                string usefulUrl = serverUrl + "/login";
                var url = usefulUrl;
                var dataToSend = new
                {
                    userName = logName,
                    password = logPassword
                };
                var json = JsonConvert.SerializeObject(dataToSend);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                try
                {
                    response = await client.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseData = await response.Content.ReadAsStringAsync();
                        var accountData = JsonConvert.DeserializeObject<_Account>(responseData);
                        account.userName = logName;
                        account = accountData;
                        Exchange exchange = new Exchange();
                        exchange.account = account;
                        exchange.serverUrl = serverUrl;
                        previousForm.Hide();
                        exchange.Show();
                        this.Close();
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
