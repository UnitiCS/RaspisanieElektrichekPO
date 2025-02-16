﻿using System;
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
    public partial class Rasstoyanie : Form
    {
        Controller.Rasstoyanie controller;
        public Rasstoyanie()
        {
            InitializeComponent();
            controller = new Controller.Rasstoyanie(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateRasstoyanie();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.DeleteRasstoyanie(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));

        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            controller.AddRasstoyanie(textBox1.Text, textBox2.Text, textBox3.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
