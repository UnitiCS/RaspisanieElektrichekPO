using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RaspisanieElektrichekPO.Controller;

namespace RaspisanieElektrichekPO.Forms
{
    public partial class Otpravlenie : Form
    {
        Controller.Otpravlenie controller;
        public Otpravlenie()
        {
            InitializeComponent();
            controller = new Controller.Otpravlenie(ConnectionString.ConnStr);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateOtpravlenie();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            controller.DeleteOtpravlenie(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.AddOtpravlenie(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }
    }
}
