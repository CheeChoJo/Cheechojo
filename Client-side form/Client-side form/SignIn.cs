using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Client_side_form
{
    public partial class SignIn : Form
    {
        public _Account account = new _Account();
        private CheeChoJoClient previousForm;
        public SignIn(CheeChoJoClient form)
        {
            InitializeComponent();
            previousForm = form;
        }
        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private async void buttonSignIn2_Click(object sender, EventArgs e)
        {
            string signName = Convert.ToString(textBoxSignName.Text);
            string signPassword = Convert.ToString(textBoxSignPass1.Text);
            string signRepeat = Convert.ToString(textBoxSignPass2.Text);
<<<<<<< HEAD
            if (signPassword == signRepeat)
            {
                using (var client = new HttpClient())
=======
            string filePath = "C:\\Users\\Public\\Documents\\" + signName + ".txt";
            if (File.Exists(filePath)) 
            {
                MessageBox.Show("Such user already exists, please choose a different username.");
            }
            else
            {
                if (signPassword == signRepeat)
>>>>>>> parent of ab22af8 (Teoreticky teď login in signin umí zavolat na server ať vytvoří/ pošle údaje na to co je potřeba)
                {
                    var url = "http://194.108.31.75:7142/login";
                    var dataToSend1 = new
                    {
                        accountName = account.userName,
                        password = signPassword,
                    };
                    var json = JsonConvert.SerializeObject(dataToSend1);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = null;
                    try
                    {
                        response = await client.PostAsync(url, content);
                        if (response.IsSuccessStatusCode)
                        {
<<<<<<< HEAD
                            MessageBox.Show("Such user already exists! Please choose another username.");
=======
                            accountName = account.userName,
                            password = signPassword,
                            balance = account.balance,
                        };
                        var json = JsonConvert.SerializeObject(dataToSend);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = null;
                        try
                        {
                            response = await client.PostAsync(url, content);
                            if (response.IsSuccessStatusCode)
                            {
                                account.userName = signName;
                                Exchange Exchange = new Exchange();
                                Exchange.account = account;
                                Exchange.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("PEBCAK Error!!!");
                            }
>>>>>>> parent of ab22af8 (Teoreticky teď login in signin umí zavolat na server ať vytvoří/ pošle údaje na to co je potřeba)
                        }
                        else
                        {
                            response = null;
                            account.userName = signName;
                            using (client)
                            {

                                var dataToSend2 = new
                                {
                                    userName = account.userName,
                                    password = signPassword,
                                    balance = 150,
                                    volume1 = 0,
                                    volume2 = 0,
                                    volume3 = 0,
                                };
                                url = "http://194.108.31.75:7142/new-user";
                                json = JsonConvert.SerializeObject(dataToSend2);
                                content = new StringContent(json, Encoding.UTF8, "application/json");
                                response = null;
                                try
                                {
                                    response = await client.PostAsync(url, content);
                                    if (response.IsSuccessStatusCode)
                                    {
                                        var responseContent = await response.Content.ReadAsStringAsync();
                                        account = JsonConvert.DeserializeObject<_Account>(responseContent);
                                        Exchange Exchange = new Exchange();
                                        Exchange.account = account;
                                        Exchange.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("PEBCAK Error!!! SignIn neprošel.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Došlo k chybě: {ex.Message}");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Došlo k chybě: {ex.Message}");
                    }
                }
<<<<<<< HEAD
            }
            else
            {
                MessageBox.Show("Passwords must match");
            }

=======
                else 
                {
                    MessageBox.Show("Passwords must match");
                }
            }
>>>>>>> parent of ab22af8 (Teoreticky teď login in signin umí zavolat na server ať vytvoří/ pošle údaje na to co je potřeba)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}
