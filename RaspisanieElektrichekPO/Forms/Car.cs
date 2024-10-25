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
    public partial class Car : Form
    {
        Controller.Car controller;
        public Car()
        {
            InitializeComponent();
            controller = new Controller.Car(ConnectionString.ConnStr);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateCar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.AddCar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.DeleteCar(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IDCar"].Value.ToString()));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Home = new Home();
            Home.Show();
        }
    }
}
