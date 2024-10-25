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
using System.Data.SqlClient;
using System.Configuration;

namespace RaspisanieElektrichekPO.Forms
{
    public partial class Ostanovki : Form
    {
        Controller.Ostanovki controller;
        public Ostanovki()
        {
            InitializeComponent();
            controller = new Controller.Ostanovki(ConnectionString.ConnStr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateOstanovki();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.AddOstanovki(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.DeleteOstanovki(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));

        }
    }
}
