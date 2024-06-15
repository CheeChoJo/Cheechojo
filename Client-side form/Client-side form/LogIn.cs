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

        public LogIn(CheeChoJoClient form)
        {
            InitializeComponent();
            previousForm = form;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            // Load event logic, if necessary
        }

        private async void buttonLogIn2_Click(object sender, EventArgs e)
        {
            string logName = textBoxLogName.Text;
            string logPassword = textBoxLogPass.Text;

            using (var client = new HttpClient())
            {
                var url = "http://10.10.4.44:7142/login";
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
                        exchange.Show();
                        this.Close();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound) // 404
                    {
                        MessageBox.Show("No such user exists!");
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden) // 403
                    {
                        MessageBox.Show("Wrong password!");
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
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
