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
    public partial class DenNedeli : Form
    {

        Controller.DenNedeli controller;

        public DenNedeli()
        {
            InitializeComponent();
            controller = new Controller.DenNedeli(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateDenNedeli();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.AddDenNedeli(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.DeleteDenNedeli(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
