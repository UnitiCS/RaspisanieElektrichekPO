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
    public partial class BrandCar : Form
    {

        Controller.BrandCar controller;

        public BrandCar()
        {
            InitializeComponent();
            controller = new Controller.BrandCar(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateBrandCar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.AddBrandCar(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.DeleteBrandCar(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IDBrand"].Value.ToString()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Home = new Home();
            Home.Show();
        }
    }
}
