using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using RaspisanieElektrichekPO;

namespace RaspisanieElektrichekPO.Forms
{
    public partial class HomeUser : Form
    {
        private SqlConnection SqlConnection = null;
        public HomeUser()
        {
            InitializeComponent();
        }

        private void HomeUser_Load(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RaspisanieElektrichek.Properties.Settings.RaspisanieElektrichekConnectionString"].ConnectionString);
            SqlConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DenNedeli DenNedeli = new DenNedeli();
            DenNedeli.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ostanovki Ostanovki = new Ostanovki();
            Ostanovki.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elektrichka Elektrichka = new Elektrichka();
            Elektrichka.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Marshryt Marshryt = new Marshryt();
            Marshryt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Napravlenie Napravlenie = new Napravlenie();
            Napravlenie.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Otpravlenie Otpravlenie = new Otpravlenie();
            Otpravlenie.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Rasstoyanie Rasstoyanie = new Rasstoyanie();
            Rasstoyanie.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Reis Reis = new Reis();
            Reis.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }
    }
}
