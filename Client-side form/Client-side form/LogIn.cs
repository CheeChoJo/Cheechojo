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

        private async void buttonLogIn2_Click(object sender, EventArgs e)
        {
            string logName = textBoxLogName.Text;
            string logPassword = textBoxLogPass.Text;

            using (var client = new HttpClient())
            {
                var url = "http://192.168.43.31:7142/login";
                var dataToSend = new
                {
                    accountName = logName,
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

                        account = accountData;
                        Exchange exchange = new Exchange();
                        exchange.account = account;
                        exchange.Show();
                        this.Hide();
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
