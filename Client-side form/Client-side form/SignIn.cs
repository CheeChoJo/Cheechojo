using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
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
        public string serverUrl { get; set; }
        public SignIn(CheeChoJoClient form)
        {
            InitializeComponent();
            previousForm = form;
        }
        private void SignIn_Load(object sender, EventArgs e)
        {

        }
        private void EmailSend(string adress) //sends email every time someone signs up
        {
            string To = adress;
            string Subject = "další spokojený uživatel Cheechoja";
            string Body = "Děkujeme za registraci. Opravud si vážíme vašich osobních údajů a hlavně peněz co jsme Vám, " + account.userName + ", právě vybílili z účtu. S pozdravem Team Cheechoja";
            string Email = "CheechojoSpam@outlook.cz";
            string Password = "FilaVila123";
            string Host = "smtp-mail.outlook.com";
            int Port = 587;
            using (MailMessage mail = new MailMessage(Email, To, Subject, Body))
            {
                using (SmtpClient smtp = new SmtpClient(Host, Port))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(Email, Password);
                    smtp.Send(mail);
                }
            }
        }

        private async void buttonSignIn2_Click(object sender, EventArgs e)
        {
            string signName = Convert.ToString(textBoxSignName.Text);
            string signPassword = Convert.ToString(textBoxSignPass1.Text);
            string signRepeat = Convert.ToString(textBoxSignPass2.Text);
            string filePath = "C:\\Users\\Public\\Documents\\" + signName + ".txt";
            if (File.Exists(filePath)) 
            {
                MessageBox.Show("Such user already exists, please choose a different username.");
            }
            else
            {
                if (signName.Length > 10)
                {
                    MessageBox.Show("Username must be shorter than 10 characters");
                }
                else
                {
                    string inputEmail = Convert.ToString(textBoxEmail.Text);
                    if (inputEmail.Contains('@'))
                    {
                        if (inputEmail.Contains('.'))
                        {
                            if (signPassword == signRepeat)
                            {
                                account.userName = signName;
                                EmailSend(inputEmail);
                                using (var client = new HttpClient())
                                {
                                    string usefulUrl = serverUrl + "/new-user";
                                    var url = usefulUrl;
                                    var dataToSend = new
                                    {
                                        userName = account.userName,
                                        password = signPassword,
                                        balance = 1000,
                                        volume1 = account.volume1,
                                        volume2 = account.volume2,
                                        volume3 = account.volume3,
                                        buySellVolume = account.buySellVolume,
                                        tickerSelected = account.tickerSelected,
                                        priceWhenSelling = account.priceWhenSelling,
                                    };
                                    var json = JsonConvert.SerializeObject(dataToSend);
                                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                                    HttpResponseMessage response = null;
                                    try
                                    {
                                        response = await client.PostAsync(url, content);
                                        if (response.StatusCode == System.Net.HttpStatusCode.Created)
                                        {
                                            account.userName = signName;
                                            account.password = signPassword;
                                            account.balance = 1000;
                                            account.volume1 = 0;
                                            account.volume2 = 0;
                                            account.volume3 = 0;
                                            account.buySellVolume = 0;
                                            Exchange exchange = new Exchange();
                                            exchange.account = account;
                                            exchange.serverUrl = serverUrl;
                                            previousForm.Hide();
                                            exchange.Show();
                                            this.Close();
                                        }
                                        else if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                                        {
                                            MessageBox.Show("Such user already exists!");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Došlo k chybě: {ex.Message}");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Passwords must match");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter a valid email.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid email.");
                    }
                }
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)//nevim tohle prostě nefunguje fuck my life... to hnedka dole funguje ale
        {
            previousForm.Show();
            this.Close();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}
