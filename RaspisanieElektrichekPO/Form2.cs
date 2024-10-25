using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaspisanieElektrichekPO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "RaspisanieElektrichekDataSet.GdeEl". При необходимости она может быть перемещена или удалена.
            this.gdeElTableAdapter.Fill(this.raspisanieElektrichekDataSet.GdeEl,
            textBox1.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (reportViewer1.ExportDialog(reportViewer1.LocalReport.ListRenderingExtensions()[0]) == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show("Документ был сохранён");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
