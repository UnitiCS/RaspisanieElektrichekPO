using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaspisanieElektrichekPO.Forms
{
    public partial class Authoriz : Form
    {
        public Authoriz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "admin")
            {
                if (textBox2.Text.Trim() == "1111")
                {
                    this.Hide();
                    HAdmin fm = new HAdmin();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль!!!");
                }
            }
            else if (textBox1.Text.Trim() == "user")
            {
                if (textBox2.Text.Trim() == "1111")
                {
                    this.Hide();
                    HomeUser fm = new HomeUser();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль!!!");
                }
            }
            else if (textBox1.Text.Trim() == "gost")
            {
                if (textBox2.Text.Trim() == "1111")
                {
                    this.Hide();
                    HomeGost fm = new HomeGost();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль!!!");
                }
            }
            else
            {
                MessageBox.Show("У Вас нет доступа!!!");
            }
        }
    }
}

