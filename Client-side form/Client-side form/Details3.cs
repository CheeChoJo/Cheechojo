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
    public partial class Details3 : Form
    {
        private Exchange previousForm;
        public Details3(Exchange form)
        {
            InitializeComponent();
            previousForm = form;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBoxRange_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
