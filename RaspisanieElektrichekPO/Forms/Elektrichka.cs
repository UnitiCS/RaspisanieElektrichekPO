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
    public partial class Elektrichka : Form
    {
        Controller.Elektrichka controller;
        public Elektrichka()
        {
            InitializeComponent();
            controller = new Controller.Elektrichka(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateElektrichka();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.DeleteElektrichka(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.AddElektrichka(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
