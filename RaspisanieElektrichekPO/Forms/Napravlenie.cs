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
    public partial class Napravlenie : Form
    {
        Controller.Napravlenie controller;
        public Napravlenie()
        {
            InitializeComponent();
            controller = new Controller.Napravlenie(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateNapravlenie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.AddNapravlenie(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.DeleteNapravlenie(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
